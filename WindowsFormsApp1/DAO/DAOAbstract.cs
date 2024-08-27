using System.Data.SqlClient;
using Model.Entidades;
using System.Data;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Formulario.DAO
{
    public abstract class DAOAbstract<T> where T:class
    {

        static private string LinhaConexao = "SERVER=LS05MPF;Database=AULA_DS;User Id=sa;Password=admsasql";
        static private SqlConnection Conexao;
        private string insertQuery, selectQuery,searchQuery;
        private bool connected=false;
        public DAOAbstract(string insertQuery,string selectQuery,string searchQuery)
        {
            if (!connected){ Conexao = new SqlConnection(LinhaConexao); }
            
            this.insertQuery = insertQuery;
            this.selectQuery = selectQuery;
            this.searchQuery = searchQuery;
        }
        protected void executeInsertion(SqlParameter[] parameters)
        {
            Conexao.Open();
            SqlCommand comando = new SqlCommand(insertQuery, Conexao);
            foreach(SqlParameter param in parameters)
            {
                comando.Parameters.Add(param);
            }
            comando.ExecuteNonQuery();
            Conexao.Close();
        }

        public abstract void Insert(T entidade);
        public abstract DataTable Search(string valueToSearch);


        public void InsertAndUpdateDataTable(T entidade,ref DataGridView dt)
        {
            Insert(entidade);
            dt.DataSource = Get();
        }

        public void SearchAndUpdateDataTable(string ValueToSearch,ref DataGridView dt)
        {
            dt.DataSource = Search(ValueToSearch);
            
        }


        protected DataTable executeSearch(SqlParameter parameter)
        {
            SqlCommand comando = new SqlCommand(searchQuery, Conexao);
            comando.Parameters.Add(parameter);
            SqlDataReader reader = comando.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);
            reader.Close();
            Conexao.Close();
            return dt;
        }

        public DataTable Get()
        {
            DataTable dt = new DataTable();
            Conexao.Open();

            SqlCommand comando = new SqlCommand(selectQuery, Conexao);


            SqlDataReader reader = comando.ExecuteReader();

            dt.Load(reader);

            reader.Close();
            Conexao.Close();
            return dt;
        }
    }
}