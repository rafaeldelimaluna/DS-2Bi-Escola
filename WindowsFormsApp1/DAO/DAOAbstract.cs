using System.Data.SqlClient;
using Model.Entidades;
using System.Data;
using System.Collections.Generic;

namespace WindowsFormsApp1.DAO
{
    public class DAOAbstract<T> where T:class
    {

        private string LinhaConexao = "SErver=LS05MPF;Database=AULA_DS;User Id=sa;Password=admsasql";
        private SqlConnection Conexao;
        private string insertQuery;
        private object entidade;
        private string databaseName;

        private string makeinsertQuery()
        {
            string query = $"INSERT INTO {databaseName} (";
            int i = 0;
            foreach (var atributo in typeof(T).GetProperties()) {
                if (i == 0)
                {
                    query += atributo.Name;
                    continue;
                }
                query += $",{atributo.Name}";
                i++;
            };
            query += ") VALUES (";
            i = 0;
            foreach(var atributo in typeof(T).GetProperties())
            {
                if (i == 0)
                {
                    query += $"@{atributo.Name}";
                    continue;
                }
                query += $",@{atributo.Name}";
            }
            query += ")";
            return query;
        }
        public DAOAbstract(T entidade,string databaseName)
        {
            this.entidade = entidade;
            this.databaseName = databaseName;
            Conexao = new SqlConnection(LinhaConexao);
            this.insertQuery=makeinsertQuery();
        }
        public void Inserir(ProfessoresEntidade professor)
        {
            Conexao.Open();

            SqlCommand comando = new SqlCommand(insertQuery, Conexao);

            int i = 0;
            object[] linha = entidade.Linha();
            foreach (var atributo in typeof(T).GetProperties())
            {
                if (atributo.Name.Contains("Id")) { continue; };
                SqlParameter parametro = new SqlParameter($"@{atributo.Name}");
                comando.Parameters.Add(parametro);
            }
            SqlParameter parametro1 = new SqlParameter("@nome", professor.Nome);
            SqlParameter parametro2 = new SqlParameter("@apelido", professor.Apelido);


            comando.ExecuteNonQuery();
            Conexao.Close();
        }

        public DataTable Get()
        {
            DataTable dt = new DataTable();
            Conexao.Open();

            string query = "SELECT * FROM PROFESSORES ORDER BY ID DESC";
            SqlCommand comando = new SqlCommand(query, Conexao);


            SqlDataReader reader = comando.ExecuteReader();

            dt.Load(reader);

            reader.Close();
            Conexao.Close();
            return dt;
        }
    }
}