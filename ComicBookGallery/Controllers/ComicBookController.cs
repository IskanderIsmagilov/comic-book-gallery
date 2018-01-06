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
        public ActionResult Detail()
        {
            var comicBook = new ComicBook()
            {
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 700,
                DescriptionHtml = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>",
                Artists = new Artist[]
                {
                    new Artist() {Role = "Script",Name = "Dan Slott"},
                    new Artist() {Role = "Pencils",Name = "Humberto Ramos"},
                    new Artist() {Role = "Inks",Name = "Victor Olazaba"},
                    new Artist() {Role = "Colors",Name = "Edgar Delgado"},
                    new Artist() {Role = "Letters",Name = "Chris Eliopoulos"}
                }
            };
            return View(comicBook);
        }
    }
}