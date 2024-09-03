using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entidades
{
    public class DisciplinaEntidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }
        public object[] Linha()
        {
            return new object[] { Id, Nome, Sigla };
        }
        public bool IsFull()
        {
            if (Linha().Contains(null)) { return false; }
            else { return true; }
        }
        public override string ToString ()
        {
            return $"{Nome} | {Sigla}";
        }
    }
}
