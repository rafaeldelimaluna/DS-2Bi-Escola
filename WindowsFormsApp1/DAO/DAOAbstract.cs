using System.Data.SqlClient;
using Model.Entidades;
using System.Data;
using System.Collections.Generic;

namespace Formulario.DAO
{
    public abstract class DAOAbstract<T> where T:class
    {

        static private string LinhaConexao = "SERVER=LS05MPF;Database=AULA_DS;User Id=sa;Password=admsasql";
        static private SqlConnection Conexao;
        private string insertQuery, selectQuery;
        public DAOAbstract(string insertQuery,string selectQuery)
        {
            Conexao = new SqlConnection(LinhaConexao);
            this.insertQuery = insertQuery;
            this.selectQuery = selectQuery;
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