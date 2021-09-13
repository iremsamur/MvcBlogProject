using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBlogProject.Controllers
{
    public class CommentController : Controller
    {
        // GET: Comment
        //Yorum listesi yani  bloga yapılan yorumlar için partialviewlist ekledim
        //Comment, About, Category  gibi sınıfı bulunanlar için kendi controller'larını oluşturdum. Sebebi Solid prensibine uygun kod olması
        public PartialViewResult CommentList()
        {
            return PartialView();
        }
        //Şimdi leave comment yani yorum bırakma alanı için partial view oluşturalım
        public PartialViewResult LeaveComment()
        {
            return PartialView();
        }

    }
}