using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ValidacaoMVC.Models;

namespace ValidacaoMVC.Controllers
{
    public class FuncionarioController : Controller
    {
        // GET: Funcionario
        public ActionResult CadastroFuncionario()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ResultadoFuncionario(FuncionarioModel model)
        {
            if (ModelState.IsValid)
            {
                return View("ResultadoFuncionario", model);
            }
            return View();
        }
    }
}