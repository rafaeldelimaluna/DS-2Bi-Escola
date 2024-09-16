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
        public DisciplinasDAO():base(insertQuery:"INSERT INTO DISCIPLINAS (Nome,Sigla) VALUES (@Nome,@Sigla)",
            selectQuery:"SELECT * FROM DISCIPLINAS ORDER BY ID DESC",
            searchQuery:"SELECT * FROM DISCIPLINAS ORDER BY ID DESC WHERE nome LIKE '%'+@Nome+'%'",
            updateQuery:"UPDATE DISCIPLINAS SET NOME=@Nome,SIGLA=@Sigla WHERE ID=@Id"
            ,tableName:"DISCIPLINAS") { }
        public override DataTable Search(string valueToSearch)
        {
            SqlParameter sp = new SqlParameter("@Nome",valueToSearch);
            return executeSearch(sp);
        }

        public override void Update(DisciplinaEntidade entidade)
        {
            SqlParameter[] parameters = new SqlParameter[] {
            new SqlParameter("@Nome", entidade.Nome),
            new SqlParameter("@Sigla", entidade.Sigla),
            new SqlParameter("@Id",entidade.Id)
            };
            executeUpdate(parameters);
        }

        public override void Insert(DisciplinaEntidade entidade)
        {
            SqlParameter[] parameters = new SqlParameter[3];
            parameters[0] = new SqlParameter("@Nome", entidade.Nome);
            parameters[1] = new SqlParameter("@Sigla", entidade.Sigla);
            executeInsertion(parameters);
        }
    }
}
