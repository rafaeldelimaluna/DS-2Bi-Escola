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
        DataTable data;
        int LinhaSelecionada;
        DataGridViewCellCollection Cells;
        DataGridViewRow SelectedRow;
        private CursoDisciplinaDAO cursoDisciplinaConn;
        private CursosDAO cursoConn;
        private DisciplinasDAO disciplinasConn;
        public CursoDisciplina()
        {
            InitializeComponent();
            cursoDisciplinaConn= new CursoDisciplinaDAO();
            cursoConn = new CursosDAO();
            disciplinasConn = new DisciplinasDAO();
            InitializeComboBoxes();
        }
        private void InitializeComboBoxes()
        {
            DisciplinaCbx.DataSource = disciplinasConn.Get();
            DisciplinaCbx.DisplayMember = "Nome";
            DisciplinaCbx.ValueMember = "Id";

            CursoCbx.DataSource = cursoConn.Get();
            DisciplinaCbx.DisplayMember = "Nome";
            DisciplinaCbx.ValueMember = "Id";
        }
        private void DisciplinaCbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private CursoDisciplinaEntidade Cadastro
        {
            get
            {
                var cadastro = new CursoDisciplinaEntidade();
                cadastro.CursoId = (int)CursoCbx.SelectedValue;
                cadastro.DisciplinaId = (int)DisciplinaCbx.SelectedValue;
                cadastro.Periodo = PeriodoCbx.Text;
                return cadastro;
            }
            set
            {
                CursoCbx.SelectedValue= value.CursoId;
                DisciplinaCbx.SelectedValue= value.DisciplinaId;
                PeriodoCbx.SelectedValue = value.Periodo;
            }
        }
        private void RegisterBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
