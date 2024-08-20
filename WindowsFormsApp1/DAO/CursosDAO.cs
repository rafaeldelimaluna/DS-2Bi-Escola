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
        public CursosDAO() : base(insertQuery:"INSERT INTO CURSOS (Nome,Area,HorarioInicio,HorarioFim,Duracao) VALUES (@Nome,@Area,@HorarioInicio,@HorarioFim,@Duracao)",
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
            new SqlParameter("@Area", entidade.Area),
            new SqlParameter("@HorarioInicio", entidade.HorarioInicio),
            new SqlParameter("@HorarioFim", entidade.HorarioFim),
            new SqlParameter("@Duracao", entidade.Duracao)
            };
            executeInsertion(parameters);
        }
    }
}
