using BusinessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBlogProject.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        BlogManager blogManager = new BlogManager();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult BlogList()
        {
            /*Şimdi bu ana sayfamızın blog sayfasının parçalarını oluşturalım. Alt parçalara geçelim.
             * Bu alt parçalar partial view'lerdir. Bütünler view olur
             Bu index.cshtml (Index yazan) kısımı bizim partial bölümlerini tutacağımız alan olacak.
            bunun için önce BlogController'da yeni bir action result eklerim
            Buradaki değişiklik yapıyorum . Çünkü bir action result değil. PartialViewResult olacak
            o yüzden geriye partial view döndürür.
            */
            //Blog listeleme işlemini yazalım
            var bloglist = blogManager.GetAll();
            //Blog Manager sınıfındaki listeleme metodunu çağırdım.

            return PartialView(bloglist);//bloglistten gelen değerleri döndürür.
            //yine Bu BlogListPartialView üzerinde sağa tıklayıp bir view eklerim.//
            //Ama bu defa create as a partial view seçerim. BlogList.cshtml isimli bir partialview ekledim.
        }
        //Şimdi yine ilk partial gibi başka partial'larda oluştururum. Bunlar içinde ilk partialview oluşturduğumda
        //yaptığım işlemlerin aynısını yapıyorum.
        //öne çıkan postlar bölümü
        public PartialViewResult FeaturedPosts()
        {
            return PartialView();
        }
        public PartialViewResult OtherFeaturedPosts()
        {
            return PartialView();
        }
        //şimdi mail subscribe için bir partial ekleyelim
        public PartialViewResult MailSubscribe()
        {
            return PartialView();
        }
        //Şimdi her bloğu açtığımda gidilecek blog detay sayfası için tüm sayfa action result eklerim.
        public ActionResult BlogDetails()
        {
            return PartialView();
        }
        public PartialViewResult BlogCover()
        {
            return PartialView();//Bloğun arka plan fotoğrafının olduğu kısım
        }
        //Blog Detayı için Partial view result oluşturalım.
        public PartialViewResult BlogReadAll()
        {
            return PartialView();
        }
        public ActionResult BlogByCategory()
        {
            return View();
        }

    }
}