using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail() //both ContentResult and RediectResult are within the ActionResult base class
        {
            if (DateTime.Today.DayOfWeek == DayOfWeek.Monday)
            {
                return Redirect("/");
            }
            return new ContentResult()
            {
                Content = "Hello from the comic book controller!"
            };
        }
    }
}