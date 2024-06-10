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
    public partial class Professores : Form
    {
        BindingSource data;
        public Professores()
        {
            InitializeComponent();
            data = new BindingSource();
            DtGridProfessores.DataSource = data;
        }
        string NomePlaceholder="Nome";
        string ApelidoPlaceholder = "Apelido";
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
        private void ClearFields()
        {
            IdNud.Value = 0;
            NomeEbx.Text = NomePlaceholder;
            NomeEbx.ForeColor = Color.Gray;
            ApelidoTbxx.Text = ApelidoPlaceholder;
            ApelidoTbxx.ForeColor = Color.Gray;
        }
        private bool DataIsCorrectly()
        {
            if (NomeEbx.Text == NomePlaceholder || NomeEbx.Text == "")
            {
                MessageBox.Show("Preencha o campo corretamente");
                return false;
            }

            if (ApelidoTbxx.Text == ApelidoPlaceholder || ApelidoTbxx.Text == "") {
                MessageBox.Show("Preencha o campo apelido corretamente");
                return false;
            }
            return true;
        }
        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            ProfessoresEntidade professor = new ProfessoresEntidade();
            if (!DataIsCorrectly()) {
                MessageBox.Show("Dados não preenchidos");
                return;
            }
            professor.Id = Convert.ToInt32(IdNud.Value);
            professor.Nome = NomeEbx.Text;
            professor.Apelido = ApelidoTbxx.Text;
            data.Add(professor);
            ClearFields();

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

        private void ApelidoTbxx_Leave(object sender, EventArgs e)
        {
            Placeholder(ApelidoTbxx, ApelidoPlaceholder);
        }

        private void ApelidoTbxx_Enter(object sender, EventArgs e)
        {
            Placeholder(ApelidoTbxx, ApelidoPlaceholder);
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ClearFields();

        }
    }
}
