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
        public Disciplinas()
        {
            InitializeComponent();
        }

        private void NomeTbx_Enter(object sender, EventArgs e)
        {

        }

        private void SiglaTbx_Enter(object sender, EventArgs e)
        {

        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            DisciplinaEntidade disciplina;
            disciplina = new DisciplinaEntidade();
            string id_str = IdTbx.Text;
            int id_value;
            int.TryParse(id_str, out id_value);
            string nome_text = NomeTbx.Text;
            string sigla_text = SiglaTbx.Text;
            bool is_ativo = isAtivoChk.Checked;
            disciplina.Nome = nome_text;
            disciplina.Sigla = sigla_text;
            disciplina.Id = id_value;
        }

        private void NomeTbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void SiglaTbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void isAtivoChk_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}
