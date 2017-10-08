using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstChallenge.Controllers
{
    public class ComicController : Controller
    {
        // GET: Comic
        public ActionResult Index()
        {
            var comics = Models.ComicBookManager.GetComicBooks();
            return View(comics);
        }
        // GET: Products/Details/5
        public ActionResult Detail(int id)
        {
            var comics = Models.ComicBookManager.GetComicBooks();
            var comic = comics.Find(p => p.ComicBookId == id);


            return View(comic);
        }
    }
   
}