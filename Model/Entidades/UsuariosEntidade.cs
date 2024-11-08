﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entidades
{
    public class UsuariosEntidade
    {
        public int Id { get; set; } = 0;
        public string Senha { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }

        public object[] Linha()
        {
            return new object[] { Id, Senha, Nome, Ativo };
        }
        public bool IsFull()
        {
            if (Linha().Contains(null)) { return false; }
            return true;
        }
    }
}
