using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Model.Entidades;
using Formulario.DAO;

namespace WindowsFormsApp1.Formularios
{
    public partial class CursoDisciplina : Form
    {
        int LinhaSelecionada;
        DataGridViewCellCollection Cells;
        private CursoDisciplinaDAO cursoDisciplinaConn;
        private CursosDAO cursoConn;
        private DisciplinasDAO disciplinasConn;
        private int currentId=0;
        public CursoDisciplina()
        {
            InitializeComponent();
            cursoDisciplinaConn= new CursoDisciplinaDAO();
            cursoConn = new CursosDAO();
            disciplinasConn = new DisciplinasDAO();
            Table.DataSource = cursoDisciplinaConn.Get();
            InitializeComboBoxes();
        }
        private void InitializeComboBoxes()
        {
            DisciplinaCbx.DataSource = disciplinasConn.Get();
            DisciplinaCbx.DisplayMember = "Nome";
            DisciplinaCbx.ValueMember = "Id";

            CursoCbx.DataSource = cursoConn.Get();
            CursoCbx.DisplayMember = "Nome";
            CursoCbx.ValueMember = "Id";
        }
        private void DisciplinaCbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private CursoDisciplinaEntidade Cadastro
        {
            get
            {
                var cadastro = new CursoDisciplinaEntidade();
                cadastro.Id = currentId;
                cadastro.CursoId = (int)CursoCbx.SelectedValue;
                cadastro.DisciplinaId = (int)DisciplinaCbx.SelectedValue;
                cadastro.Periodo = PeriodoCbx.Text;
                return cadastro;
            }
            set
            {
                currentId= value.Id;
                DisciplinaCbx.SelectedValue= value.DisciplinaId;
                PeriodoCbx.SelectedValue = value.Periodo;
            }
        }
        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            cursoDisciplinaConn.InsertAndUpdateDataTable(Cadastro, ref Table);
            Cadastro = new CursoDisciplinaEntidade();
        }

        private void Table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LinhaSelecionada = e.RowIndex;
            Cells = Table.Rows[LinhaSelecionada].Cells;
            var cursoDisciplina = new CursoDisciplinaEntidade
            {
                Id = Convert.ToInt32(Cells[0].Value),
                CursoId = Convert.ToInt32(Cells[1].Value),
                DisciplinaId = Convert.ToInt32(Cells[2].Value),
                Periodo = Cells[3].Value.ToString()
            };
            Cadastro = cursoDisciplina;
            DeleteBtn.Text = $"Deletar registro Id:{currentId}";
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            cursoDisciplinaConn.UpdateAndUpdateDataTable(Cadastro, ref Table);
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            cursoDisciplinaConn.DeleteAndUpdateDataTable(currentId, ref Table);
        }
    }
}
