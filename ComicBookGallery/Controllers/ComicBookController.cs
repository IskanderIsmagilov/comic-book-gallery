using ComicBookGallery.Data;
using ComicBookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        private ComicBookRepository _comicBookRepo = new ComicBookRepository();        
        
        public ActionResult Index()
        {
            var comicBooks = _comicBookRepo.GetComicBooks();
            return View(comicBooks);
        }

        public ActionResult Detail(int? id)
        {
            if (id != null)
            {
                ComicBook comicBook = _comicBookRepo.GetComicBook((int)id);
                return View(comicBook);
            }
            return HttpNotFound();
        }

        public ActionResult Series(string seriesTitle)
        {
            if (seriesTitle != null)
            {
                ComicBook[] series = _comicBookRepo.GetSeries(seriesTitle);
                return View(series);
            }
            return HttpNotFound();
        }
    }
}