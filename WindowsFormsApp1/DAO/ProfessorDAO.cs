using System.Data.SqlClient;
using Model.Entidades;
using System.Data;


namespace Formulario.DAO
{


    public class ProfessorDAO:DAOAbstract<ProfessoresEntidade>
    {

        public ProfessorDAO():base(
            insertQuery:"Insert into professores (Nome,Apelido) VALUES (@nome, @apelido)",
            selectQuery: "SELECT * FROM PROFESSORES ORDER BY ID DESC",
            searchQuery:"SELECT * FROM PROFESSORES ORDER BY ID DESC WHERE NOME LIKE '%'+@nome+'%'",
            updateQuery:"UPDATE PROFESSORES SET NOME=@Nome,APELIDO=@Apelido WHERE ID=@Id",
            tableName:"PROFESSORES")
        {
        }

        public override DataTable Search(string valueToSearch)
        {
            SqlParameter sp = new SqlParameter("@nome", valueToSearch);
            return executeSearch(sp);
        }

        public override void Update(ProfessoresEntidade entidade)
        {
            SqlParameter[] parameters = new SqlParameter[] {
            new SqlParameter("@nome", entidade.Nome),
            new SqlParameter("@apelido", entidade.Apelido),
            new SqlParameter("@Id",entidade.Id)
            };
            executeInsertion(parameters);
        }

        public override void Insert(ProfessoresEntidade professor)
        {
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@nome", professor.Nome);
            parameters[1] = new SqlParameter("@apelido", professor.Apelido);
            executeInsertion(parameters);

        }
    }
}