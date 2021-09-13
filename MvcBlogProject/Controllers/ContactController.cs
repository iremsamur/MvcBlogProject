using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBlogProject.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        //Şimdi Contact alanı için olan Contact sınıfının controller'ını oluşturduk. Contact ile ilgili işlemler burada yazılır
        public ActionResult Index()
        {
            return View();
        }
    }
}