using System.Data.SqlClient;
using Model.Entitidades;


namespace WindowsFormsApp1.DAO
{
   

    class ProfessorDAO
    {

        private string LinhaConexao = "SErver=L505MPF;Database=AULA_DS;User Id=sa;Password=admsql";
        private SqlConnection Conexao;
      public ProfessorDAO() { 
        Conexao = new SqlConnection(LinhaConexao);
        }
    public void Inserir(ProfessoresEntidade professor)
    {
        Conexao.Open();
        string query = "Insert into professores (Nome,Apleido) VALUES (@nome, @apelido)";
        SqlCommand comando = new SqlCommand(query, Conexao);
        SqlParameter parametro1 = new SqlParameter("@nome", professor.Nome);
        SqlParameter parametro2 = new SqlParameter("@apelido", professor.Apelido);
        comando.Parameters.Add(parametro1);
        comando.Parameters.Add(parametro2);
        comando.ExecuteNonQuery();
        Conexao.Close();
    }
}
