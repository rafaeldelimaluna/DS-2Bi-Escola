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
    public partial class salas : Form
    {
        public salas()
        {
            InitializeComponent();
        }
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
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void SalasCadastroHeaderLabel_Click(object sender, EventArgs e)
        {

        }

        private void NameEntry_Enter(object sender, EventArgs e)
        {
            Placeholder(NameEntry,"Nome da Sala");
        }
    }
}
