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
        DataGridViewCellCollection cells;
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
            NomeTbx.Text = "";
            AreaTbx.Text = "";
            HorarioFimTbx.Text = "";
            HorarioInicioTbx.Text = "";
            DuracaoNud.Value = (int)DuracaoNud.Value+1;
        }
        private void UpdateSelectedCellsVar()
        {
            DataGridViewCellCollection cells =Table.Rows[LinhaSelecionada].Cells;
        }
        private void UpdateSelectedRowVar(){
            DataGridViewRow SelectedRow =Table.Rows[LinhaSelecionada].Cells;

        }
        private void Table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LinhaSelecionada = e.RowIndex;
            UpdateSelectedCellsVar();
            CursosEntidade curso = new CursosEntidade();
            curso.Nome = cells[0].Value.ToString();
            curso.Area = cells[1].Value.ToString();
            curso.HorarioInicio = cells[2].Value.ToString();
            curso.HorarioFim = cells[3].Value.ToString();
            curso.Duracao = Convert.ToInt32(cells[4].Value);
            SetFieldsValues(curso);

        }
        private void EditBtn_Click(object sender,EventArgs e){
            UpdateSelectedRowVar();
            UpdateSelectedCellsVar();
            EditBtn.Text = $"Editar Linha {LinhaSelecionada}";
            Cells[0].Value= (int)Nome.Value;
            Cells[1].Value=AreaTbx.Text;
            Cells[2].Value= HorarioInicioTbx.Text;
            Cells[3].Value= HorarioFimTbx.Text;
            Cells[4].Value= (int)Duracao.Value;
        }
        private void DeleteRowBtn_Click(object sender, EventArgs e)
        {
            UpdateSelectedRowVar();
            SelectedRow.RemoveAt(LinhaSelecionada);


        }
    }
}
