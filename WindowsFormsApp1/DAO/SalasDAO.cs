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
        public SalasDAO() : base(insertQuery: "INSERT INTO SALAS (NOME,NUMERO_COMPUTADORES,NUMERO_CADEIRAS,PREDIO,ISLAB,DISPONIVEL) VALUES(@Nome,@NumeroComputadores,@NumeroCadeiras,@Predio,@IsLab,@Disponivel)",
            selectQuery:"SELECT * FROM SALAS ORDER BY ID DESC",
            searchQuery:"SELECT * FROM AULAS ORDER BY ID DESC WHERE @Nome LIKE '%'+Nome+'%'",
            tableName:"SALAS")
        {
        }

        public override DataTable Search(string valueToSearch)
        {
            SqlParameter sp = new SqlParameter("@Nome", valueToSearch);
            return executeSearch(sp);
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
