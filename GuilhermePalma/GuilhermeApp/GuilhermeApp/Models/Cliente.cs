using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GuilhermeApp.Models
{
    public class Cliente
    {
        int clienteId, rg, clienteTel;
        string digRg, clienteNome;
        Int64 cpf;

        public Cliente(int clienteId, int rg, int clienteTel, string digRg, string clienteNome, long cpf)
        {
            this.clienteId = clienteId;
            this.rg = rg;
            this.clienteTel = clienteTel;
            this.digRg = digRg;
            this.clienteNome = clienteNome;
            this.cpf = cpf;
        }

        public int ClienteId { get => clienteId; set => clienteId = value; }
        public int Rg { get => rg; set => rg = value; }
        public int ClienteTel { get => clienteTel; set => clienteTel = value; }
        public string DigRg { get => digRg; set => digRg = value; }
        public string ClienteNome { get => clienteNome; set => clienteNome = value; }
        public long Cpf { get => cpf; set => cpf = value; }
    }
}