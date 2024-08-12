using System;
using System.Data;
using System.Windows.Forms;
using Model.Entidades;
namespace WindowsFormsApp1
{
    public partial class Cursos : Form
    {
        DataTable data;
        int LinhaSelecionada;
        DataGridViewCellCollection Cells;
        DataGridViewRow SelectedRow;
        public Cursos()
        {
            InitializeComponent();
            data = new DataTable();
            Table.DataSource = data;
            foreach(var attributes in typeof(CursosEntidade).GetProperties())
            {
                data.Columns.Add(attributes.Name);
            }
            data.Rows.Add("24", "Superior", "18:00", "18:50", 50);
        }
        private CursosEntidade Cadastro
        {
            get
            {
                CursosEntidade curso = new CursosEntidade();

                curso.Nome = NomeTbx.Text;
                curso.Area = AreaTbx.Text;
                curso.HorarioFim = HorarioFimTbx.Text;
                curso.HorarioInicio = HorarioInicioTbx.Text;
                curso.Duracao = ((int)DuracaoNud.Value);
                return curso;
            }
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            CursosEntidade curso = Cadastro;
            if (!curso.IsFull())
            {
                MessageBox.Show("Tem campo vazio aí!");
            }
            data.Rows.Add(curso.Linha());
                }

        private void SetFieldsValues(CursosEntidade curso)
        {
            NomeTbx.Text = curso.Nome;
            AreaTbx.Text = curso.Area;
            HorarioFimTbx.Text = curso.HorarioFim;
            HorarioInicioTbx.Text = curso.HorarioInicio;
            DuracaoNud.Value = curso.Duracao;
        }
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            NomeTbx.Text = "";
            AreaTbx.Text = "";
            HorarioFimTbx.Text = "";
            HorarioInicioTbx.Text = "";
            DuracaoNud.Value = (int)DuracaoNud.Value+1;
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
            curso.Nome = Cells[0].Value.ToString();
            curso.Area = Cells[1].Value.ToString();
            curso.HorarioInicio = Cells[2].Value.ToString();
            curso.HorarioFim = Cells[3].Value.ToString();
            curso.Duracao = Convert.ToInt32(Cells[4].Value);
            SetFieldsValues(curso);

        }
        private void DeleteRowBtn_Click(object sender, EventArgs e)
        {
            UpdateSelectedRowVar();
            data.Rows[LinhaSelecionada].Delete();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            UpdateSelectedRowVar();
            UpdateSelectedCellsVar();
            EditBtn.Text = $"Editar Linha {LinhaSelecionada+1}";
            Cells[0].Value = NomeTbx.Text;
            Cells[1].Value = AreaTbx.Text;
            Cells[2].Value = HorarioInicioTbx.Text;
            Cells[3].Value = HorarioFimTbx.Text;
            Cells[4].Value = (int)DuracaoNud.Value;
        }
    }
}
