using System;
using System.Data;
using System.Windows.Forms;
using Formulario.DAO;
using Model.Entidades;


namespace Formulario
{
    public partial class Cursos : Form
    {
        DataTable data;
        int LinhaSelecionada;
        DataGridViewCellCollection Cells;
        DataGridViewRow SelectedRow;
        CursosDAO conn;
        public Cursos()
        {
            InitializeComponent();
            data = new DataTable();
            conn = new CursosDAO();
            Table.DataSource = conn.Get();
            foreach(var attributes in typeof(CursosEntidade).GetProperties())
            {
                data.Columns.Add(attributes.Name);
            }
        }
        private CursosEntidade Cadastro
        {
            get
            {
                CursosEntidade curso = new CursosEntidade();
                curso.Id = (int)IdNUD.Value;
                curso.Nome = NomeTbx.Text;
                curso.Ativo=AtivoChk.Checked;
                curso.Turno=TurnoTbx.Text;
                curso.Sigla=SiglaTbx.Text;
                return curso;
            }
            set
            {
                IdNUD.Value = value.Id;
                NomeTbx.Text = value.Nome;
                SiglaTbx.Text = value.Sigla;
                TurnoTbx.Text = value.Turno;
                AtivoChk.Checked = value.Ativo;
            }
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            CursosEntidade curso = Cadastro;
            if (!curso.IsFull())
            {
                MessageBox.Show("Tem campo vazio aí!");
            }
            conn.InsertAndUpdateDataTable(Cadastro, ref Table);
            //data.Rows.Add(curso.Linha());
        }
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            NomeTbx.Text = "";
            SiglaTbx.Text = "";
            TurnoTbx.Text = "";
            AtivoChk.Checked = false;
        }
        private void UpdateSelectedCellsVar()
        {
            Cells= Table.Rows[LinhaSelecionada].Cells;
        }
        private void UpdateSelectedRowVar(){
            
            SelectedRow = Table.Rows[LinhaSelecionada];

        }
        private void Table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LinhaSelecionada = e.RowIndex;
            UpdateSelectedCellsVar();
            DeleteRowBtn.Text = $"Excluir linha {LinhaSelecionada + 1}";
            CursosEntidade curso = new CursosEntidade();
            curso.Id = Convert.ToInt32(Cells[0].Value);
            curso.Nome = Cells[1].Value.ToString();
            curso.Sigla = Cells[2].Value.ToString();
            curso.Turno = Cells[3].Value.ToString();
            curso.Ativo = Convert.ToBoolean(Cells[4].Value);
            Cadastro = curso;

        }
        private void DeleteRowBtn_Click(object sender, EventArgs e) => conn.DeleteAndUpdateDataTable((int)IdNUD.Value, ref Table);

        private void EditBtn_Click(object sender, EventArgs e)
        {
            UpdateSelectedRowVar();
            UpdateSelectedCellsVar();
            var curso = Cadastro;
            EditBtn.Text = $"Editar Linha Id:{curso.Id}";
            conn.UpdateAndUpdateDataTable(curso, ref Table);
        }

        private void SearchTbx_TextChanged(object sender, EventArgs e)
        {
            conn.SearchAndUpdateDataTable(SearchTbx.Text, ref Table);
        }

    }
}
