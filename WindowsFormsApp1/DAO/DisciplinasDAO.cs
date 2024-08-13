using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulario.DAO
{
    class DisciplinasDAO : DAOAbstract<Disciplinas>
    {
        public DisciplinasDAO():base("INSERT INTO DISCIPLINAS (Nome,Sigla,Ativo) VALUES (@Nome,@Sigla,@Ativo)","SELECT * FROM DISCIPLINAS ORDER BY ID DESC") { }
        public override void Insert(Disciplinas entidade)
        {
            throw new NotImplementedException();
        }
    }
}
