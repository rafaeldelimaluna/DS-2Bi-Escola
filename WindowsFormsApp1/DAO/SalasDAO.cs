using Model.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Formulario.DAO
{
    class SalasDAO : DAOAbstract<SalasEntidade>
    {
        public SalasDAO() : base(insertQuery: "INSERT INTO SALAS (NOME,NUMEROCOMPUTADORES,NUMEROCADEIRAS,ISLAB,DISPONIVEL) VALUES(@Nome,@NumeroComputadores,@NumeroCadeiras,@IsLab,@Disponivel)",
            selectQuery:"SELECT Id,Nome,NUMEROCOMPUTADORES,NUMEROCADEIRAS,ISLAB,DISPONIVEL FROM SALAS ORDER BY ID DESC",
            searchQuery: "SELECT Id,Nome,NUMEROCOMPUTADORES,NUMEROCADEIRAS,ISLAB,DISPONIVEL FROM SALAS WHERE Nome LIKE '%'+@Nome+'%' ORDER BY ID DESC ",
            updateQuery: "UPDATE SALAS SET NOME=@Nome,NUMEROCOMPUTADORES=@NumeroComputadores,NUMEROCADEIRAS=@NumeroCadeiras,ISLAB=@isLab,DISPONIVEL=@Disponivel WHERE ID=@Id",
            tableName:"SALAS")
        {
        }

        public override DataTable Search(string valueToSearch)
        {
            SqlParameter sp = new SqlParameter("@Nome", valueToSearch);
            return executeSearch(sp);
        }

        public override void Update(SalasEntidade entidade)
        {
            SqlParameter[] parameters = new SqlParameter[] {
            new SqlParameter("@Nome", entidade.Nome),
            new SqlParameter("@NumeroComputadores", entidade.NumeroComputadores),
            new SqlParameter("@NumeroCadeiras", entidade.NumeroCadeiras),
            new SqlParameter("@IsLab", entidade.IsLab),
            new SqlParameter("@Disponivel", entidade.Disponivel),
            new SqlParameter("@Id", entidade.Id)

        };
            executeUpdate(parameters);
        }

        public override void Insert(SalasEntidade sala)
        {
            SqlParameter[] parameters = new SqlParameter[] {
            
            
            new SqlParameter("@Nome", sala.Nome),
            new SqlParameter("@NumeroComputadores", sala.NumeroComputadores),
            new SqlParameter("@NumeroCadeiras", sala.NumeroCadeiras),
            new SqlParameter("@IsLab", sala.IsLab),
            new SqlParameter("@Disponivel", sala.Disponivel)
        };
        executeInsertion(parameters);
        }

    }
}
