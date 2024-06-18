using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Utils
{
    public class Table
    {
        private int CurrentRow;
        private DataTable Table;
        public Table(DataTable Table)
        {
            this.Table = Table;
        }
        public int LinhaSelecionada{
            get { return CurrentRow; }
            set { CurrentRow = value; }

        }
        public void Edit(object entidade)
        {
            var olaf = Table.Rows[LinhaSelecionada];
        }

    }
}
