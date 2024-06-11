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
    public partial class Disciplinas : Form
    {
        private DataTable data;
        private int LinhaSelecionada;
        private string NomePlaceholder, SiglaPlaceholder;
        public Disciplinas()
        {
            InitializeComponent();
            data = new BindingSource();
            Table.DataSource = data;
            SetPlaceholders();
        }

        private void SetPlaceholders()
        {
            NomePlaceholder = NomeTbx.Text;
            SiglaPlaceholder = SiglaTbx.Text;
        }
        private void NomeTbx_Enter(object sender, EventArgs e)
        {

        }

        private void SiglaTbx_Enter(object sender, EventArgs e)
        {

        }

        private void ClearFields()
        {
            NomeTbx.Text = "Nome";
            SiglaTbx.Text = "Sigla";
            IdNud.Value = 0;
        }
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
        private bool VerifyFields()
        {
            return true;
        }
        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            DisciplinaEntidade disciplina;
            disciplina = new DisciplinaEntidade();
            int IdValue= Convert.ToInt32(IdNud.Value);
            string nome_text = NomeTbx.Text;
            string sigla_text = SiglaTbx.Text;
            bool is_ativo = isAtivoChk.Checked;
            disciplina.Nome = nome_text;
            disciplina.Sigla = sigla_text;
            disciplina.Id = IdValue;
            disciplina.Ativo = is_ativo;
            data.Add(disciplina);
            ClearFields();
        }

        private object[] Linha()
        {
            return new object[] { Id };
        }
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ClearFields();

        }
    }
}
