using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model.Entitidades;

namespace WindowsFormsApp1
{

    public partial class Salas : Form
    {
        DataTable dados;
        int LinhaSelecionada;
        private SalasEntidade sala1 = new SalasEntidade();
        public Salas()
        {
            InitializeComponent();
            dados = new DataTable();
            RegistersDGVCadastroSalas.DataSource = dados;
            foreach (var attributes in typeof(SalasEntidade).GetProperties())
            {
                dados.Columns.Add(attributes.Name);
            }
        }
        private String NameEntry_PlaceHolder = "Nome da Sala";
        private String PCsNumber_PlaceHolder= "Número de PCs";
        private String ChairEntry_Placeholder= "Número de Cadeiras";
        private String BuildingEntry_Placeholder= "Prédio";
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
            dados.Rows.Add(sala);
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
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void SaveRegisterButton_Click(object sender, EventArgs e)
        {
            SalasEntidade sala = new SalasEntidade();
            sala.Nome = NameEntry.Text;
            sala.IsLab = IsLabChk.Checked;
            sala.NumeroCadeiras= Convert.ToInt32(ChairEntry.Text);
            sala.NumeroComputadores = Convert.ToInt32(PCsNumberEntry.Text);
            sala.Predio = BuildingEntry.Text;
            dados.Rows.Add(sala);
        }


        private void DeleteRowBtn_Click(object sender, EventArgs e)
        {
        }

        private void RegistersDGVCadastroSalas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LinhaSelecionada = e.RowIndex;
            DataGridViewCellCollection cells= RegistersDGVCadastroSalas.Rows[LinhaSelecionada].Cells;
            SalasEntidade sala = new SalasEntidade();
            if (cells[0].Value.ToString() == null)
            {
                return;
            }
            //sala.Nome = cells[0].Value;
            //            sala.NumeroComputadores = Convert.ToInt32(cells[1].Value);
            //            sala.NumeroCadeiras= Convert.ToInt32(cells[2].Value);
            //sala.Predio= cells[3].Value;
            //sala.IsLab= Convert.ToBoolean(cells[4].Value);
        }
    }
}
