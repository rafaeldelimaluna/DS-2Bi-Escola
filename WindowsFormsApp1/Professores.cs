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
    public partial class Professores : Form
    {
        public Professores()
        {
            InitializeComponent();
        }
        string NomePlaceholder="Nome";
        //string ApelidoPlaceholder="Apelido";
        private void Placeholder(TextBox textBox, String placeholder_value)
        {
            String textBox_text = textBox.Text;

            if (textBox_text == placeholder_value)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
            }
            else if (textBox_text == "")
            {
                textBox.Text = placeholder_value;
                textBox.ForeColor = Color.Gray;
            }
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {

        }

        private void NomeEbx_Enter(object sender, EventArgs e)
        {
            Placeholder(NomeEbx, NomePlaceholder);
        }

        private void ApelidoTbx(object sender, EventArgs e)
        {
            //Placeholder(ApelidoTbx, ApelidoPlaceholder);
        }

        private void ApelidoTbx_Enter(object sender, EventArgs e)
        {
            //Placeholder(ApelidoTbx, ApelidoPlaceholder);

        }

        private void NomeEb_Leave(object sender, EventArgs e)
        {
            Placeholder(NomeEbx, NomePlaceholder);

        }
    }
}
