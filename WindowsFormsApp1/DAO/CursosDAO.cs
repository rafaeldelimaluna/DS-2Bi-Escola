using Formulario.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulario.DAO
{
    class CursosDAO:DAOAbstract<Cursos>
    {
        public CursosDAO() : base("INSERT INTO CURSOS (Nome,Area,HorarioInicio,HorarioFim,Duracao) VALUES (@Nome,@Area,@HorarioInicio,@HorarioFim,@Duracao)","SELECT * FROM CURSOS ORDER BY ID DESC")
        {

        }

        public override void Insert(Cursos entidade)
        {
            throw new NotImplementedException();
        }
    }
}
