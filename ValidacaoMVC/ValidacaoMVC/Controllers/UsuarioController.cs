using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ValidacaoMVC.Models
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult CadastroUsuario()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ResultadoUsuario(UsuarioModel model)
        {
            if (ModelState.IsValid)
            {
                return View("ResultadoUsuario", model);
            }
            return View();
        }

    }
}