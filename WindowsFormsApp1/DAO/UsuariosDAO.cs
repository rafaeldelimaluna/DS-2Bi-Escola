using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Model.Entidades;
using System.Data;
using WindowsFormsApp1.Formularios;

namespace Formulario.DAO
{
    class UsuariosDAO:DAOAbstract<UsuariosEntidade>
    {
        public UsuariosDAO():base(insertQuery: "INSERT INTO USUARIOS (Login,Senha,Ativo) VALUES (@Nome,@Senha,@Ativo)",
            selectQuery:"SELECT Id,Login as Nome,Senha,Ativo FROM USUARIOS ORDER BY ID DESC",
            searchQuery:"SELECT Id,Login as Nome,Senha,Ativo FROM USUARIOS ORDER BY ID DESC WHERE @Nome LIKE '%'+@Nome+'%'",
            updateQuery: "UPDATE USUARIOS SET Login=@Login,Senha=@Senha,Nome=@Nome,Ativo=@Ativo WHERE ID=@Id",
            tableName:"USUARIOS")
        {

        }

        public override DataTable Search(string valueToSearch)
        {
            SqlParameter sp = new SqlParameter("@Nome", valueToSearch);
            return executeSearch(sp);
        }
        public override void Update(UsuariosEntidade entidade)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Nome", entidade.Nome),
                new SqlParameter("@Senha", entidade.Senha),
                new SqlParameter("@Ativo", entidade.Ativo),
                new SqlParameter("@Id", entidade.Id),

            };
            executeUpdate(parameters);
        }
        public override void Insert(UsuariosEntidade entidade)
        {
            SqlParameter[] parameters = new SqlParameter[]
             {
                new SqlParameter("@Nome", entidade.Nome),
                new SqlParameter("@Senha", entidade.Senha),
                new SqlParameter("@Ativo", entidade.Ativo),

             };
            executeInsertion(parameters);
        }

        public UsuariosEntidade Login(UsuariosEntidade entidade)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Nome",entidade.Nome),
                new SqlParameter("@Senha",entidade.Senha)
            };

            var query = "SELECT TOP 1 * from USUARIOS WHERE SENHA=@Senha, Nome=@Nome";

            var reader = GetFirst(query,parameters);

            var entidadeObj = new UsuariosEntidade()
            {
                Id=reader.GetInt32(0),
                Nome=reader.GetString(1),
                Senha=reader.GetString(2)
            };



            reader.Close();
            CloseConexao();

            return entidadeObj;
        }
    }
}