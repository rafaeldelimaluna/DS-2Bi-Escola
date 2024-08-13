using Model.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Formulario.DAO
{
    class SalasDAO : DAOAbstract<SalasEntidade>
    {
        public SalasDAO() : base("INSERT INTO SALAS (NOME,NUMERO_COMPUTADORES,NUMERO_CADEIRAS,PREDIO,ISLAB) VALUES(@Nome,@NumeroComputadores,@NumeroCadeiras,@Predio,@IsLab)", "SELECT * FROM SALAS ORDER BY ID DESC")
        {

        }
        public override void Insert(SalasEntidade sala)
        {
            SqlParameter[] parameters = new SqlParameter[4];
            parameters[0] = new SqlParameter("@Nome", sala.Nome);
            parameters[1] = new SqlParameter("@NumeroComputadores", sala.NumeroComputadores);
            parameters[2] = new SqlParameter("@NumeroCadeiras", sala.NumeroCadeiras);
            parameters[3] = new SqlParameter("@Predio", sala.Predio);
            parameters[4] = new SqlParameter("@IsLab", sala.IsLab);
            executeInsertion(parameters);
        }

    }
}
