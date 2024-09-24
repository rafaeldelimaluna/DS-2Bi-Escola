using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Formulario.DAO;
using Model.Entidades;

namespace Formulario
{

    public partial class Salas : Form
    {
        DataTable data;
        int LinhaSelecionada;
        private SalasDAO conn;
        public Salas()
        {
            InitializeComponent();
            data = new DataTable();
            conn = new SalasDAO();
            Table.DataSource = conn.Get();
            foreach (var attributes in typeof(SalasEntidade).GetProperties())
            {
                data.Columns.Add(attributes.Name);
            }
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            
            conn.InsertAndUpdateDataTable(Cadastro, ref Table);
            Cadastro = new SalasEntidade();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            Cadastro = new SalasEntidade();
        }

        private SalasEntidade Cadastro
        {
            get
            {
                SalasEntidade sala = new SalasEntidade();
                sala.Id = (int)IdNud.Value;
                sala.Nome = NameEntry.Text;
                sala.IsLab = IsLabChk.Checked;
                sala.NumeroCadeiras = (int)NumeroCadeirasNud.Value;
                sala.NumeroComputadores = (int)NumeroPcsNud.Value;
                sala.Disponivel = DisponivelChk.Checked;
                return sala;
            }
            set
            {
                IdNud.Value = value.Id;
                NameEntry.Text = value.Nome;
                NumeroPcsNud.Value = value.NumeroComputadores;
                NumeroCadeirasNud.Value= value.NumeroCadeiras;
                IsLabChk.Checked = value.IsLab;
                DisponivelChk.Checked = value.Disponivel;
            }
        }
        private void SaveRegisterButton_Click(object sender, EventArgs e)
        {
            SalasEntidade sala = Cadastro;
            if (!sala.IsFull())
            {
                MessageBox.Show("Tem coisa vazia");
                return;
            }
            data.Rows.Add(sala);
        }


        private void DeleteRowBtn_Click(object sender, EventArgs e)
        {
            DeleteRowBtn.Text = $"Excluir registro Id:{Cadastro.Id}";
            conn.DeleteAndUpdateDataTable(Cadastro.Id, ref Table);
        }
        private SalasEntidade MakeObjLinhaSelecionada()
        {
            DataGridViewCellCollection Cells=Table.Rows[LinhaSelecionada].Cells;
            SalasEntidade sala = new SalasEntidade();
            sala.Id= Convert.ToInt32(Cells[0].Value);
            sala.Nome = Cells[1].Value.ToString();
            sala.NumeroComputadores = Convert.ToInt32(Cells[2].Value);
            sala.NumeroCadeiras = Convert.ToInt32(Cells[3].Value);
            sala.IsLab = Convert.ToBoolean(Cells[4].Value);
            sala.Disponivel = Convert.ToBoolean(Cells[5].Value);
            return sala;
        }


        private void SetValuesInRow(SalasEntidade sala)
        {
            DataGridViewCellCollection Cells = Table.Rows[LinhaSelecionada].Cells;
            Cells[0].Value = sala.Id;
            Cells[1].Value= sala.Nome;
            Cells[2].Value= sala.NumeroComputadores;
            Cells[3].Value= sala.NumeroCadeiras;
            Cells[4].Value= sala.IsLab;
            Cells[5].Value= sala.Disponivel;
        }
        private void EditBtn_Click(object sender, EventArgs e)
        {
            SalasEntidade sala = Cadastro;
            if (!sala.IsFull())
            {
                return;
            }
            conn.UpdateAndUpdateDataTable(Cadastro, ref Table);

        }

        private void Table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LinhaSelecionada = e.RowIndex;
            DeleteRowBtn.Text = $"Excluir registro:{Cadastro.Id}";
            EditBtn.Text = $"Editar Registro:{Cadastro.Id}";
            SalasEntidade sala = MakeObjLinhaSelecionada();
            Cadastro = sala;
        }

        private void SearchTbx_TextChanged(object sender, EventArgs e)
        {
            conn.SearchAndUpdateDataTable(SearchTbx.Text, ref Table);
        }
    }
}
