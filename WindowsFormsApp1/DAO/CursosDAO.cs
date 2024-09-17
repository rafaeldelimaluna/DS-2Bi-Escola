using Formulario.DAO;
using Model.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Formulario.DAO
{
    class CursosDAO:DAOAbstract<CursosEntidade>
    {
        public CursosDAO() : base(insertQuery: "INSERT INTO CURSOS (Curso,Turno,Sigla,Ativo) VALUES (@Nome,@Turno,@Sigla,@Ativo)",
            selectQuery:"SELECT Id,Nome,Sigla,Turno,Ativo FROM CURSOS ORDER BY ID DESC",
            searchQuery: "SELECT Id,Nome,Sigla,Turno,Ativo FROM CURSOS WHERE Nome LIKE '%'+@Nome+'%' ORDER BY ID DESC",
            updateQuery: "UPDATE CURSOS SET Nome=@Nome,Sigla=@Sigla,Turno=@Turno,Ativo=@Ativo WHERE ID=@Id"
            , tableName:"CURSOS"
            )
        {

        }
        public override DataTable Search(string valueToSearch)
        {
            SqlParameter sp=new SqlParameter("@Nome", valueToSearch);
            return executeSearch(sp);
        }
        public override void Update(CursosEntidade entidade)
        {
            SqlParameter[] parameters = new SqlParameter[] {
            new SqlParameter("@Nome", entidade.Nome),
            new SqlParameter("@Turno", entidade.Turno),
            new SqlParameter("@Sigla", entidade.Sigla),
            new SqlParameter("@Ativo", entidade.Ativo),
            new SqlParameter("@Id", entidade.Id),
            };
            executeUpdate(parameters);
        }
        public override void Insert(CursosEntidade entidade)
        {
            SqlParameter[] parameters = new SqlParameter[] {
            new SqlParameter("@Nome", entidade.Nome),
            new SqlParameter("@Turno", entidade.Turno),
            new SqlParameter("@Sigla", entidade.Sigla),
            new SqlParameter("@Ativo", entidade.Ativo),
            };
            executeInsertion(parameters);
        }
    }
}
