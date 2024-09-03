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


            DisciplinaCbx.Items.Add(new DisciplinaEntidade { Id = 1, Nome = "Olaf", Sigla = "O" });

        }

        private void DisciplinaCbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
