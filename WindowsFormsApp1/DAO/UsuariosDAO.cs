using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Model.Entidades;

namespace Formulario.DAO
{
    class UsuariosDAO:DAOAbstract<UsuariosEntidade>
    {
        public UsuariosDAO():base("INSERT INTO USUARIOS (Email,Senha,Nome,Ativo) VALUES (@Email,@Senha,@Nome,@Ativo)","SELECT * FROM USUARIOS ORDER BY ID DESC")
        {

        }

        public override void Insert(UsuariosEntidade entidade)
        {
            SqlParameter[] parameters = new SqlParameter[4];
            parameters[0] = new SqlParameter("@Email",entidade.Email);
            parameters[1] = new SqlParameter("@Senha", entidade.Senha);
            parameters[2] = new SqlParameter("@Nome", entidade.Nome);
            parameters[3] = new SqlParameter("@Ativo", entidade.Ativo);
            executeInsertion(parameters);
        }
    }
}
