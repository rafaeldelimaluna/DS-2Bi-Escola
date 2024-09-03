using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Formularios;

namespace Formulario
{
    public partial class Main : Form
    {
        private bool is_salas_instancied,isCursosInstancied,IsProfessoresInstancied,IsUsuariosInstancied,IsDisciplinaInstancied,IsCursoDisciplinaInstancied;
        private Salas salas;
        private Cursos cursos;
        private Professores professores;
        private Usuarios usuarios;
        private DisciplinasEntidade disciplinas;
        private CursoDisciplina cursoDisciplina;

        private void professoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsProfessoresInstancied)
            {
                professores.Focus();
            }
            else
            {
                professores = new Professores();
                professores.Show();
                IsProfessoresInstancied = true;
            }
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsUsuariosInstancied)
            {
                usuarios.Show();
            }
            else
            {
                usuarios = new Usuarios();
                usuarios.Show();
                IsUsuariosInstancied=true;
            }
        }

        private void disciplinaEntidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsCursoDisciplinaInstancied)
            {
                cursoDisciplina.Show();
            }
            else
            {
                cursoDisciplina= new CursoDisciplina();
                cursoDisciplina.Show();
                IsCursoDisciplinaInstancied= true;
            }
        }

        private void disciplinasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsDisciplinaInstancied)
            {
                disciplinas.Show();
            }
            else
            {
                disciplinas = new DisciplinasEntidade();
                disciplinas.Show();
                IsDisciplinaInstancied = true;
            }
        }

        public Main()
        {
            InitializeComponent();
        }

        private void salasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (is_salas_instancied)
            {
                salas.Focus();
            }
            else
            {
                salas = new Salas();
                salas.Show();
                is_salas_instancied = true;
            }

        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isCursosInstancied)
            {
                cursos.Show();
            }
            else
            {
                cursos = new Cursos();
                cursos.Show();
                isCursosInstancied = true;
            }
        }
    }
}
