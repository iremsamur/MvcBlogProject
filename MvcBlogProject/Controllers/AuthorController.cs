using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBlogProject.Controllers
{
    public class AuthorController : Controller
    {
        // GET: Author
        //Yazar kısımı için Author controller ekledim. Yine içinde partial'lar olacak.
        public PartialViewResult AuthorAbout()
        {
            return PartialView();
        }
        public PartialViewResult AuthorPopularPost()
        {
            return PartialView();
        }
    }
}