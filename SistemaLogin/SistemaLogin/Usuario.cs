﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLogin
{
    public class Usuario
    {
        public Usuario(string nome, string senha)
        {
            Nome = nome;
            Senha = senha;
        }

        public Usuario() { }

        public string Nome { get; set; }
        public string Senha { get; set; }
    }
}
