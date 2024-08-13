using Formulario.DAO;
using Model.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Formulario.DAO
{
    class CursosDAO:DAOAbstract<CursosEntidade>
    {
        public CursosDAO() : base("INSERT INTO CURSOS (Nome,Area,HorarioInicio,HorarioFim,Duracao) VALUES (@Nome,@Area,@HorarioInicio,@HorarioFim,@Duracao)","SELECT * FROM CURSOS ORDER BY ID DESC")
        {

        }

        public override void Insert(CursosEntidade entidade)
        {
            SqlParameter[] parameters = new SqlParameter[4];
            parameters[0] = new SqlParameter("@Nome", entidade.Nome);
            parameters[1] = new SqlParameter("@Area", entidade.Area);
            parameters[2] = new SqlParameter("@HorarioInicio", entidade.HorarioInicio);
            parameters[3] = new SqlParameter("@HorarioFim", entidade.HorarioFim);
            parameters[4] = new SqlParameter("@Duracao", entidade.Duracao);
            executeInsertion(parameters);
        }
    }
}
