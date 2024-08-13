using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Model.Entidades;

namespace Formulario.DAO
{
    class DisciplinasDAO : DAOAbstract<DisciplinaEntidade>
    {
        public DisciplinasDAO():base("INSERT INTO DISCIPLINAS (Nome,Sigla,Ativo) VALUES (@Nome,@Sigla,@Ativo)","SELECT * FROM DISCIPLINAS ORDER BY ID DESC") { }
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
