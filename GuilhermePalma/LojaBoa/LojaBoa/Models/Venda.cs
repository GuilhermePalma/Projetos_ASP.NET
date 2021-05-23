using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaBoa.Models
{
    public class Venda
    {
        private decimal preco;
        private DateTime data;
        private int quantidade;

        public decimal Preco { get => preco; set => preco = value; }
        public DateTime Data { get => data; set => data = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }
    }
}