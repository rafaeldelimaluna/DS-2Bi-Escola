using System.Linq;

namespace Model.Entidades
{
    public class CursosEntidade
    {
        public int Id { get; set; } = 0;
        public string Nome { get; set; }
        public string Turno { get; set; }
        public string Sigla { get; set; }
        public bool Ativo { get; set; }
        public bool IsFull()
        {
            if (Linha().Contains(null)) { return false; }
            else { return true; }
        }

        public object[] Linha()
        {
            return new object[] { Id,Nome,Turno,Sigla,Ativo };
        }
    }
}
