﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaGames.Dominio
{
    public class Opcional
    {
        public int IdOpcional { get; private set; }
        public string Nome { get; private set; }
        public double ValorDiaria { get; private set; }
        public int QuantidadeTotal { get; set; }

        protected Opcional() { }

        public Opcional(string nome, double valorDiaria, int quantidadeTotal, Produto console)
        {
            Nome = nome;
            ValorDiaria = valorDiaria;
            QuantidadeTotal = quantidadeTotal;
        }
    } 
}