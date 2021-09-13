using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBlogProject.Controllers
{
    /*Controller backend tarafında işin kodlarını yazacağım kısımdır. Bunu view'e bağlarım.
     Controller backend kodlarını ifade eder. View tarafı tasarımdır.
    Bizim buradaki üçlü katman entity,dataAccess,Business modelimizi oluşturur.*/
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}