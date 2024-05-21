using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Salas : Form
    {
        public Salas()
        {
            InitializeComponent();
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
            else
            {
                textBox.Text = placeholder_value;
                textBox.ForeColor = Color.LightGray;
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
            if (NameEntry.Text == NameEntry_PlaceHolder) 
            { 
                SetWarning("Campo nome vazio"); 
                return; 
            }
            if (PCsNumberEntry.Text !=PCsNumber_PlaceHolder)
            {
                //! Char.IsDigit(PCsNumberEntry.Text,0) &&  !Char.IsDigit(PCsNumberEntry.Text,1) && 
                SetWarning("O campo número de pcs deve conter valores NUMÉRICOS");
                return; 
            }
            if (ChairEntry.Text==ChairEntry_Placeholder) 
            {
                SetWarning("Número de cadeiras vazio"); return; 
            }
            if (BuildingEntry.Text==BuildingEntry_Placeholder) 
            {
                SetWarning("Campo Prédio vazio"); 
                return; 
            }
        }
    }
}
