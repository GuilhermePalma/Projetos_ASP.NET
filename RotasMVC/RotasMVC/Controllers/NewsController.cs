using RotasMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RotasMVC.Controllers
{
    public class NewsController : Controller
    {
        private IEnumerable<News> news = new News().allNews().OrderByDescending(x => x.Date);

        public ActionResult Criatividade()
        {
            return View(news);
        }

        public ActionResult AllNews()
        {
            return View(news);
        }
        public ActionResult LastNews()
        {
            // Pega somente 3 noticias
            var lastNews = news.Take(3);

            // Pega as Categorias de Forma distinta e cria uma List
            var categorys = news.Select(x => x.Category).Distinct().ToList();

            ViewBag.Categorys = categorys;

            return View(lastNews);
        }

        public ActionResult ShowNews(int newsIdChosed)
        {
            var result = news.FirstOrDefault(x => x.Id == newsIdChosed);
            return View(result);
        }

        public ActionResult ShowCategory(string category)
        {
            // Pega as Categorias de Forma distinta e cria uma List
            var categorys = news.Where(x => x.Category.ToLower() == category.ToLower()).ToList(); 

            ViewBag.Category = category;

            return View(categorys);
        }

    }
}