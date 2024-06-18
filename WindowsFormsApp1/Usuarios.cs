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
    public partial class Usuarios : Form
    {
        DataTable data;
        public Usuarios()
        {
            data = new DataTable();
            foreach(var attributes in typeof(UsuariosEntidade).GetProperties())
            {
                data.Columns.Add(attributes.Name);
            }
            dataGridView1.DataSource = data;
            //data.Rows.Add(1, "rafael luna", "rafaelluna@hotmail.com", "DS", "4984984");
            InitializeComponent();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {

        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
