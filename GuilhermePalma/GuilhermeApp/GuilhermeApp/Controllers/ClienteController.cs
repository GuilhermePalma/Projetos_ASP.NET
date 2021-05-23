using GuilhermeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GuilhermeApp.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            Cliente cliente = new Cliente(1, 12345678, 123456789, "0", "Bela", 12345678911);
            ViewBag.MessageCod = "Código: " + cliente.ClienteId ;
            ViewBag.MessageNome = "Nome: " + cliente.ClienteNome;
            ViewBag.MessageCPF = "CPF: " + cliente.Cpf;
            ViewBag.MessageRG = "RG: " + cliente.Rg + " - " + cliente.DigRg;
            ViewBag.MessageTelefone = "Telefone: " + cliente.ClienteTel;

            return View();
        }

    }
}