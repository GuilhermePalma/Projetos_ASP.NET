using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GuilhermeApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "A app tem como objetivo demonstrar todos os conhecimentos" +
                " adquiridos na disciplina Desenvolvimento de Software";

            return View();
        }

        public ActionResult GuilhermeApp()
        {
            return View();
        }

    }
}