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
    public partial class DisciplinasEntidade : Form
    {
        private DataTable data;
        private int LinhaSelecionada;
        private DataGridViewRow CurrentRow;
        private DAOAbstract<DisciplinaEntidade> conn;
        public DisciplinasEntidade()
        {
            InitializeComponent();
            conn = new DisciplinasDAO();
            data = new DataTable();
            Table.DataSource = data;
            foreach(var attributes in typeof(DisciplinaEntidade).GetProperties())
            {
                data.Columns.Add(attributes.Name);
            }
            //InsertSampleRows();
        }


        private DisciplinaEntidade Cadastro{
            get{
                DisciplinaEntidade disciplina;
                disciplina = new DisciplinaEntidade();
                disciplina.Id= Convert.ToInt32(IdNud.Value);
                disciplina.Nome= NomeTbx.Text;
                disciplina.Sigla= SiglaTbx.Text;
                return disciplina;
            }
            set
            {
                IdNud.Value = (int)value.Id;
                NomeTbx.Text = value.Nome;
                SiglaTbx.Text = value.Sigla;
            }
        }
        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            DisciplinaEntidade disciplina = Cadastro;
            if (!disciplina.IsFull()) { return; }
            conn.InsertAndUpdateDataTable(disciplina, ref Table);
            Cadastro = new DisciplinaEntidade();
        }
        private DisciplinaEntidade MakeObjectDisciplinasEntidade(DataGridViewRow Rows){
            DataGridViewCellCollection Cells= Rows.Cells;
             DisciplinaEntidade disciplina = new DisciplinaEntidade();
            disciplina.Id= Convert.ToInt32(Cells[0].Value);
            disciplina.Nome = Cells[1].Value.ToString();
            disciplina.Sigla = Cells[2].Value.ToString();


            return disciplina;
        }

        private void Table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LinhaSelecionada = e.RowIndex;
            CurrentRow = Table.Rows[LinhaSelecionada];
            DeleteRowBtn.Text = $"Excluir linha {Cadastro.Id}";
            DisciplinaEntidade disciplina = MakeObjectDisciplinasEntidade(CurrentRow);
            Cadastro = disciplina;
        }

        private void DeleteRowBtn_Click(object sender, EventArgs e)
        {
            data.Rows[LinhaSelecionada].Delete();
            conn.DeleteAndUpdateDataTable(Cadastro.Id, ref Table);
        }

        private void EditRowBtn_Click(object sender, EventArgs e)
        {
            DisciplinaEntidade disciplina = Cadastro;
            if (CurrentRow == null || !disciplina.IsFull())
            {
                return;
            }
            CurrentRow.SetValues(disciplina.Linha());
        }


        private void SearchTbx_TextChanged(object sender, EventArgs e)
        {
            conn.SearchAndUpdateDataTable(SearchTbx.Text, ref Table);

        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            Cadastro = new DisciplinaEntidade();

        }
    }
}
