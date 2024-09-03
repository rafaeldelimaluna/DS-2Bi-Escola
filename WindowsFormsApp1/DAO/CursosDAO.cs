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
        public CursosDAO() : base(insertQuery: "INSERT INTO CURSOS (Nome,Turno,Sigla,Ativo) VALUES (@Nome,@Turno,@Sigla,@Ativo)",
            selectQuery:"SELECT * FROM CURSOS ORDER BY ID DESC",
            searchQuery:"SELECT * FROM CURSOS ORDER BY ID DESC WHERE LIKE @Nome"
            )
        {

        }
        public override DataTable Search(string valueToSearch)
        {
            SqlParameter sp=new SqlParameter("@Nome", valueToSearch);
            return executeSearch(sp);
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
