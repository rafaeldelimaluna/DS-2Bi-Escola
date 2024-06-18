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
        DataTable data;
        int LinhaSelecionada;
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

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            CursosEntidade curso = new CursosEntidade();
            curso.Nome = NomeTbx.Text;
            curso.Area = AreaTbx.Text;
            curso.HorarioFim = HorarioFimTbx.Text;
            curso.HorarioInicio = HorarioInicioTbx.Text;
            curso.Duracao = ((int)DuracaoNud.Value);
            data.Rows.Add(curso);
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

        }

        private void Table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LinhaSelecionada = e.RowIndex;
            DataGridViewCellCollection cells =Table.Rows[LinhaSelecionada].Cells;
            CursosEntidade curso = new CursosEntidade();
            curso.Nome = cells[0].Value.ToString();
            curso.Area = cells[1].Value.ToString();
            curso.HorarioInicio = cells[2].Value.ToString();
            curso.HorarioFim = cells[3].Value.ToString();
            curso.Duracao = Convert.ToInt32(cells[4].Value);
            SetFieldsValues(curso);

        }
    }
}
