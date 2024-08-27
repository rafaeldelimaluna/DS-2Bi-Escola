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
            Table.DataSource = data;
            foreach (var attributes in typeof(SalasEntidade).GetProperties())
            {
                data.Columns.Add(attributes.Name);
            }
            AddSampleRows();
        }
        private String NameEntry_PlaceHolder = "Nome da Sala";
        private String PCsNumber_PlaceHolder= "Número de PCs";
        private String ChairEntry_Placeholder= "Número de Cadeiras";
        private String BuildingEntry_Placeholder= "Prédio";

        private void AddSampleRows()
        {
            SalasEntidade s1 = new SalasEntidade();
            s1.Nome = "Olaf";
            s1.NumeroComputadores = 20;
            s1.NumeroCadeiras = 19;
            s1.Predio = "1 andar";
            s1.IsLab = true;
            data.Rows.Add(s1.Linha());
            SalasEntidade s2 = new SalasEntidade();
            s2.Nome = "Rodlfo";
            s2.NumeroComputadores = 45;
            s2.NumeroCadeiras = 45;
            s2.Predio = "Torres gemesas";
            s2.IsLab = false;
            data.Rows.Add(s2.Linha());

        }
        private void Placeholder(TextBox textBox,String placeholder_value)
        {
            String textBox_text = textBox.Text;

            if (textBox_text == placeholder_value)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
            }
            else if(textBox_text == "")
            {
                textBox.Text = placeholder_value;
                textBox.ForeColor = Color.Gray;
            }
        }

        private void NameEntry_Enter(object sender, EventArgs e)
        {
            Placeholder(NameEntry,NameEntry_PlaceHolder);
        }

        private void PCsNumber_Enter(object sender, EventArgs e)
        {
            Placeholder(PCsNumberEntry, PCsNumber_PlaceHolder);
        }

        private void ChairEntry_Enter(object sender, EventArgs e)
        {
            Placeholder(ChairEntry, ChairEntry_Placeholder);
        }

        private void BuildingEntry_Enter(object sender, EventArgs e)
        {
            Placeholder(BuildingEntry, BuildingEntry_Placeholder);
        }
        
        private void SetWarning(String TextWarning)
        {
            WarningLabel.Text = $"ERRO {TextWarning}";
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            int NumberPCs;
            int NumberChairs;

            if (NameEntry.Text == NameEntry_PlaceHolder) 
            { 
                SetWarning("Campo [nome] vazio"); 
                return; 
            }
            if (PCsNumberEntry.Text ==PCsNumber_PlaceHolder)
            {
                //! Char.IsDigit(PCsNumberEntry.Text,0) &&  !Char.IsDigit(PCsNumberEntry.Text,1) && 
                SetWarning("O campo [número de pcs] está vazio");
                return; 
            }
            int.TryParse(PCsNumberEntry.Text, out NumberPCs);
            if (NumberPCs == 0)
            {
                SetWarning("O campo [número de pcs] deve conter valores NUMÉRICOS");
                return;
            }
            if (ChairEntry.Text==ChairEntry_Placeholder) 
            {
                SetWarning("[Número de cadeiras] vazio"); return; 
            }
            int.TryParse(ChairEntry.Text, out NumberChairs);
            if (NumberChairs == 0)
            {
                SetWarning("[Número de cadeiras] deve conter números naturais");
                return;
            }
            if (BuildingEntry.Text==BuildingEntry_Placeholder) 
            {
                SetWarning("Campo Prédio vazio"); 
                return; 
            }
            SalasEntidade sala = new SalasEntidade();
            sala.Nome = NameEntry.Text;
            sala.NumeroComputadores = NumberPCs;
            sala.NumeroCadeiras = NumberChairs;
            sala.Predio = BuildingEntry.Text;
            sala.IsLab = IsLabChk.Checked;
            conn.InsertAndUpdateDataTable(sala, ref Table);
            //data.Rows.Add(sala.Linha());
            ClearForm();
        }
        private void ClearForm()
        {
            NameEntry.Text = NameEntry_PlaceHolder;
            NameEntry.ForeColor = Color.Gray;
            PCsNumberEntry.Text = PCsNumber_PlaceHolder;
            PCsNumberEntry.ForeColor = Color.Gray;
            ChairEntry.Text = ChairEntry_Placeholder;
            ChairEntry.ForeColor = Color.Gray;
            BuildingEntry.Text = BuildingEntry_Placeholder;
            BuildingEntry.ForeColor = Color.Gray;
        }

        private void Setfields(SalasEntidade sala)
        {
            NameEntry.Text = sala.Nome;
            PCsNumberEntry.Text = sala.NumeroComputadores.ToString();
            ChairEntry.Text = sala.NumeroCadeiras.ToString();
            BuildingEntry.Text = sala.Predio;
            IsLabChk.Checked = sala.IsLab;
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private SalasEntidade Cadastro
        {
            get
            {
                SalasEntidade sala = new SalasEntidade();
                sala.Nome = NameEntry.Text;
                sala.IsLab = IsLabChk.Checked;
                sala.NumeroCadeiras = Convert.ToInt32(ChairEntry.Text);
                sala.NumeroComputadores = Convert.ToInt32(PCsNumberEntry.Text);
                sala.Predio = BuildingEntry.Text;
                return sala;
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
            data.Rows[LinhaSelecionada].Delete();
        }
        private SalasEntidade MakeObjLinhaSelecionada()
        {
            DataGridViewCellCollection Cells=Table.Rows[LinhaSelecionada].Cells;
            SalasEntidade sala = new SalasEntidade();
            sala.Nome = Cells[0].Value.ToString();
            sala.NumeroComputadores = Convert.ToInt32(Cells[1].Value);
            sala.NumeroCadeiras = Convert.ToInt32(Cells[2].Value);
            sala.Predio = Cells[3].Value.ToString();
            sala.IsLab = Convert.ToBoolean(Cells[4].Value);
            return sala;
        }


        private void SetValuesInRow(SalasEntidade sala)
        {
            DataGridViewCellCollection Cells = Table.Rows[LinhaSelecionada].Cells;
            Cells[0].Value= sala.Nome;
            Cells[1].Value= sala.NumeroComputadores.ToString();
            Cells[2].Value= sala.NumeroCadeiras;
            Cells[3].Value= sala.Predio.ToString();
            Cells[4].Value= sala.IsLab;
        }
        private void EditBtn_Click(object sender, EventArgs e)
        {
            SalasEntidade sala = Cadastro;
            if (!sala.IsFull())
            {
                return;
            }
            SetValuesInRow(sala);

        }

        private void Table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LinhaSelecionada = e.RowIndex;
            DeleteRowBtn.Text = $"Excluir linha {LinhaSelecionada + 1}";
            EditBtn.Text = $"Editar linha {LinhaSelecionada + 1}";
            SalasEntidade sala = MakeObjLinhaSelecionada();
            Setfields(sala);
        }

        private void SearchTbx_TextChanged(object sender, EventArgs e)
        {
            conn.SearchAndUpdateDataTable(SearchTbx.Text, ref Table);
        }
    }
}
