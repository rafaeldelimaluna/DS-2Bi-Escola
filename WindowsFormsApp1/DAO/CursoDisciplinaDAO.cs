using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Model.Entidades;

namespace Formulario.DAO
{
    public class CursoDisciplinaDAO:DAOAbstract<CursoDisciplinaEntidade>
    {
        public CursoDisciplinaDAO() : base(
            insertQuery:"INSERT INTO Curso_Disciplina (Curso_Id, Disciplina_Id, Periodo) VALUES(@curso_id,@disciplina_id,@periodo);"
            ,selectQuery:""
            ,searchQuery:"") { }

        public override void Insert(CursoDisciplinaEntidade entidade)
        {
            SqlParameter[] sp = new SqlParameter[] {
            new SqlParameter("@curso_id",entidade.CursoId),
            new SqlParameter("@disciplina_id",entidade.DisciplinaId),
            new SqlParameter("@periodo",entidade.Periodo)
            };
            executeInsertion(sp);
        }

        public override DataTable Search(string valueToSearch)
        {
            throw new NotImplementedException();
        }
    }
}
