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
    public partial class Cursos : Form
    {
        BindingSource data;
        public Cursos()
        {
            InitializeComponent();
            data = new BindingSource();
            Table.DataSource = data;
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            //NomeTbx.Text;
            //AreaTbx.Text;
            //HorarioFimTbx.Text;
            //HorarioInicioTbx.Text;
            //DuracaoTbx.Text;
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
