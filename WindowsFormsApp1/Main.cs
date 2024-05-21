using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Main : Form
    {
        private bool is_salas_instancied;
        private Salas salas;
        public Main()
        {
            InitializeComponent();
        }

        private void MainRegisterRoomBtn_Click(object sender, EventArgs e)
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
    }
}
