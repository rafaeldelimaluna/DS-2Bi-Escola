using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Model.Entidades;
using System.Data;

namespace Formulario.DAO
{
    class DisciplinasDAO : DAOAbstract<DisciplinaEntidade>
    {
        public DisciplinasDAO():base(insertQuery:"INSERT INTO DISCIPLINAS (Nome,Sigla,Ativo) VALUES (@Nome,@Sigla,@Ativo)",
            selectQuery:"SELECT * FROM DISCIPLINAS ORDER BY ID DESC",
            searchQuery:"SELECT * FROM DISCIPLINAS ORDER BY ID DESC WHERE nome LIKE '%@Nome%'") { }
        public override DataTable Search(string valueToSearch)
        {
            SqlParameter sp = new SqlParameter("@Nome",valueToSearch);
            return executeSearch(sp);
        }
        public override void Insert(DisciplinaEntidade entidade)
        {
            SqlParameter[] parameters = new SqlParameter[3];
            parameters[0] = new SqlParameter("@Nome", entidade.Nome);
            parameters[1] = new SqlParameter("@Sigla", entidade.Sigla);
            parameters[2] = new SqlParameter("@Ativo", entidade.Ativo);
            executeInsertion(parameters);
        }
    }
}
