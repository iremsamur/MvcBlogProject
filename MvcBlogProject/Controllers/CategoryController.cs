using BusinessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBlogProject.Controllers
{
    public class CategoryController : Controller
    {
        //Ben Category işlemleri için bir controller yani CategoryController oluşturdum.
        // GET: Category
        CategoryManager categoryManager = new CategoryManager();
        public ActionResult Index()
        {
            var categoryList = categoryManager.GetAll();//CategoryManager sınıfını tanımladığım için view yani 
            //arayüzde bu listelemeyi bana göstermesi için GetAll() metodunu tekrar çağırırım. 
            return View(categoryList);//View de bunu göstermesini sağlar.
            //GetAll category entitiesinde bulunan repository'e bağlı olarak veri listeleme yapar. List Dal katmanında, Category entities içinde concrete klasöründe
            //Ben burada BusinessLayer içindeki metodu çağırdım. Çünkü Entities Data Access Layer'a Business Data Access Layer ve Entities katmanına 
            //User Interface ise üç katmanada bağlıdır. Ama bu user interface 'deki ilgili sınıf alan için yapılacak olan işlemlerin
            //yazıldığı controlller mesela burada Category işlemleri için Category controller'ı BusinessLayer'da CategoryManager sınıfındaki
            //ilgili metodları çağırır. Hep kodlar bu yapıda yazılır. Her sınıf için.
            //Yani tüm katmanları kullanmış oluyorum. Ve projemdeki her alan için tablolar için oluşan sınıfların 
            //hepsi için kendi adıyla gerekli sınıf ve interface ler katmanlarında oluşturulur. Category
            //// işlemleri için oluşan Category sınıfı için Mesela CategoryManager , CategoryController gibi
            //Şimdi controller'da listeleme işlemini yapacak olan Index Action Result'ına bir view eklerim.
            //buradaki businessdaki süzgeç mesela şu olabilir category'i listeleme yetkisi var mı bunun kontrolü
        }
        //Kategoriler kısımı için Blog DEtails bölümündeki
        public PartialViewResult BlogDetailsCategoryList()
        {
            return PartialView();
        }
    }
}