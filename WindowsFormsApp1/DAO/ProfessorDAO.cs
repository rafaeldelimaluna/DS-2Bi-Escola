using System.Data.SqlClient;
using Model.Entidades;
using System.Data;


namespace Formulario.DAO
{


    public class ProfessorDAO
    {

        private string LinhaConexao = "SErver=LS05MPF;Database=AULA_DS;User Id=sa;Password=admsasql";
        private SqlConnection Conexao;
        public ProfessorDAO()
        {
            Conexao = new SqlConnection(LinhaConexao);
        }
        public void Inserir(ProfessoresEntidade professor)
        {
            Conexao.Open();
            string query = "Insert into professores (Nome,Apelido) VALUES (@nome, @apelido)";

            SqlCommand comando = new SqlCommand(query, Conexao);


            SqlParameter parametro1 = new SqlParameter("@nome", professor.Nome);
            SqlParameter parametro2 = new SqlParameter("@apelido", professor.Apelido);
            comando.Parameters.Add(parametro1);
            comando.Parameters.Add(parametro2);


            comando.ExecuteNonQuery();
            Conexao.Close();
        }

        public DataTable Get()
        {
            DataTable dt = new DataTable();
            Conexao.Open();

            string query = "SELECT * FROM PROFESSORES ORDER BY ID DESC";
            SqlCommand comando = new SqlCommand(query, Conexao);


            SqlDataReader reader=  comando.ExecuteReader();

            dt.Load(reader);

            reader.Close();
            Conexao.Close();
            return dt;
        }
    }
}