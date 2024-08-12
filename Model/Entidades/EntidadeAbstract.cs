using System.Linq;

namespace Model.Entidades
{
    abstract class EntidadeAbstract
    {
        public abstract object[] Linha();
        public bool IsFull()
        {
            if (Linha().Contains(null)) { return false; }
            else { return true; }
        }
    }
}
