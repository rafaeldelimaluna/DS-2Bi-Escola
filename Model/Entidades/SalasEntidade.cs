using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entidades
{
    public class SalasEntidade
    {
        public string Nome { get; set; }
        public int NumeroComputadores { get; set; }
        public int NumeroCadeiras { get; set; }
        public string Predio { get; set; }
        public bool IsLab { get; set; }
        public object[] Linha()
        {
            return new object[] { Nome, NumeroComputadores, NumeroCadeiras, Predio,IsLab};
        }
        public bool IsFull()
        {
            if (Linha().Contains(null)) { return false; }
            return true;
        }
    }
}
