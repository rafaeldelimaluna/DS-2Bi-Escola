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
        private DataGridViewRows CurrentRow;
        private string NomePlaceholder, SiglaPlaceholder;
        public Disciplinas()
        {
            InitializeComponent();
            data = new DataTable();
            Table.DataSource = data;
            foreach(var attributes in typeof(DisciplinaEntidade).GetProperties())
            {
                data.Columns.Add(attributes.Name);
            }
            data.Rows.Add(0, "Matemática", "Mat");
            data.Rows.Add(1, "História", "Hist");
            data.Rows.Add(2, "Biologia", "Bio");
            data.Rows.Add(3, "Física", "Fis");
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
        private DisciplinaEntidade Cadastro{
            get{
            DisciplinaEntidade disciplina;
            disciplina = new DisciplinaEntidade();
            int IdValue= Convert.ToInt32(IdNud.Value);
            string nome_text = NomeTbx.Text;
            string sigla_text = SiglaTbx.Text;
            bool is_ativo = isAtivoChk.Checked;
            return disciplina;
            }
        }
        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            DisciplinaEntidade disciplina = Cadastro;
            disciplina.Nome = nome_text;
            disciplina.Sigla = sigla_text;
            disciplina.Id = IdValue;
            disciplina.Ativo = is_ativo;
            data.Rows.Add(disciplina);
            ClearFields();
        }
        private void SetFieldsValues(DisciplinaEntidade disciplina){
            NomeTbx.Text=disciplina.Nome;
            SiglaTbx.Text=disciplina.Sigla;
            IdNud.Value=disciplina.Id;
            isAtivoChk.Checked=disciplina.Ativo;
        }
        private DisciplinaEntidade MakeObjectDisciplinasEntidade(DataGridViewRows Rows){
             disciplina = Cadastro;
             Rows.SetValues(disciplina.Linha());
        }
        private void Table_CellClick(object sender, EventArgs e){
            LinhaSelecionada=e.RowIndex;
            CurrentRow = Table.Rows[LinhaSelecionada];
            DisciplinaEntidade disciplina = MakeObjectDisciplinasEntidade(CurrentRow);
            SetFields(disciplina);
        }
    private void EditBtn_Click(object sender, EventArgs e){
            disciplina = Cadastro;
            CurrentRow.SetValues(disciplina.Linha());
    }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ClearFields();

        }
    }
}
