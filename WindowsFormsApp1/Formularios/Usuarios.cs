using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Formulario.DAO;
using Model.Entidades;
namespace Formulario
{
    public partial class Usuarios : Form
    {
        DataTable data;
        int LinhaSelecionada;
        private UsuariosDAO conn;
        public Usuarios()
        {
            InitializeComponent();
            data = new DataTable();
            conn = new UsuariosDAO();
            Table.DataSource = conn.Get();
        }

        private UsuariosEntidade Cadastro
        {
            get
            {
                UsuariosEntidade usuario = new UsuariosEntidade();
                usuario.Id=Convert.ToInt32(IdNud.Value);
                usuario.Ativo = IsAtivoChk.Checked;
                usuario.Nome = NomeCompletoTbx.Text;
                usuario.Senha = SenhaTbx.Text;

                return usuario;
            }
            set
            {
                IdNud.Value = value.Id;
                EmailTbx.Text = value.Nome;
                SenhaTbx.Text = value.Senha;
                IsAtivoChk.Checked = value.Ativo;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ClearForm()
        {
            IdNud.Value=Convert.ToInt32(IdNud.Value+1);
            IsAtivoChk.Checked=false;
            NomeCompletoTbx.Text="";
            SenhaTbx.Text="";
            EmailTbx.Text = "";

        }
        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            UsuariosEntidade usuario = Cadastro;
            ClearForm();
            conn.InsertAndUpdateDataTable(usuario,ref Table);
            //data.Rows.Add(usuario.Linha());

        }

        private void DeleteRowBtn_Click(object sender, EventArgs e)
        {
            data.Rows[LinhaSelecionada].Delete();
            DeleteRowBtn.Text = $"Excluir registro Id:{Cadastro.Id}";
            conn.DeleteAndUpdateDataTable(Cadastro.Id, ref Table);
        }

        private void EditRowBtn_Click(object sender, EventArgs e)
        {
            
            conn.UpdateAndUpdateDataTable(Cadastro,ref Table);
            ClearForm();
        }

        private void NomeCompletoTbx_TextChanged(object sender, EventArgs e)
        {

        }
        private UsuariosEntidade MakeObjByCurrentRow()
        {
            DataGridViewCellCollection Cells =Table.Rows[LinhaSelecionada].Cells;
            UsuariosEntidade usuario = new UsuariosEntidade();
            usuario.Id=Convert.ToInt32(Cells[0].Value);
            usuario.Nome = Cells[1].Value.ToString();
            usuario.Senha = Cells[2].Value.ToString();
            usuario.Ativo = Convert.ToBoolean(Cells[3].Value);
            return usuario;
        }

        private void SetFields(UsuariosEntidade usuario)
        {
            IdNud.Value= usuario.Id;
            EmailTbx.Text = usuario.Nome;
            SenhaTbx.Text = usuario.Senha;
            IsAtivoChk.Checked=usuario.Ativo;
        }
        private void SetValuesInCurrentRow(UsuariosEntidade usuario)
        {
            DataGridViewCellCollection Cells= Table.Rows[LinhaSelecionada].Cells;
            Cells[0].Value= usuario.Id;
            Cells[1].Value= usuario.Nome;
            Cells[2].Value= usuario.Senha;
            Cells[3].Value= usuario.Ativo;
        }

        private void Table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LinhaSelecionada = e.RowIndex;
            UsuariosEntidade usuario = MakeObjByCurrentRow();
            SetFields(usuario);


        }

        private void SearchTbx_TextChanged(object sender, EventArgs e)
        {
            conn.SearchAndUpdateDataTable(SearchTbx.Text, ref Table);
        }
    }
}
