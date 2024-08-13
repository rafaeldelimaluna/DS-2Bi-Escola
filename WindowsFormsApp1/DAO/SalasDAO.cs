using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulario.DAO
{
    class SalasDAO : DAOAbstract<Salas>
    {
        public SalasDAO() : base("INSERT INTO SALAS (NOME,NUMERO_COMPUTADORES,NUMERO_CADEIRAS,PREDIO,ISLAB) VALUES(@Nome,@NumeroComputadores,@NumeroCadeiras,@Predio,@IsLab)", "SELECT * FROM SALAS ORDER BY ID DESC")
        {

        }
        public override void Insert(Salas sala)
        {
            throw new NotImplementedException();
        }

    }
}
