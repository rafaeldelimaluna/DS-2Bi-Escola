using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulario.DAO
{
    class UsuariosDAO:DAOAbstract<Usuarios>
    {
        public UsuariosDAO():base("INSERT INTO USUARIOS (Email,Senha,Nome,Ativo) VALUES (@Email,@Senha,@Nome,@Ativo)","SELECT * FROM USUARIOS ORDER BY ID DESC")
        {

        }

        public override void Insert(Usuarios entidade)
        {
            throw new NotImplementedException();
        }
    }
}
