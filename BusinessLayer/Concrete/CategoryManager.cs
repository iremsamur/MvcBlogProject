using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager
    /*Business Layer'ın amacı Data Access Layer'da tanımladığım veritabanı işlemlerini burada süzgeçten geçirir. 
     * Eğer benim istediğim şartlar sağlanıyorsa buna User Interface yani kullanıcı arayüzü katmanına gönder demektir.
     * Yine Business Layer'ada somut sınıfları içerecek Concrete klasörünü ekledim. Ve içine somut sınıf eklerim.
     * BusinessLayer'da sınıf adlandırmaları önce entityLayer'da bulunan hangi sınıf için iş koşulları yazacaksam o sınıfın adı yazılır sonra sonuna Manager Eklenir. 
     * Mesela Category sınıfı için CategoryManager olur.
     *///yine bu katman için ihtiyacımız olan Data Access Ve Entity Layer referanslarını ekleriz.
    {
        Repository<Category> repoCategory = new Repository<Category>();
        //önce CategoryManager için Business yazarız. bunun için Repository sınıfındaki methodları kullanmam gerekir.
        //Bunu sağlamak için Repository sınıfını içine Category sınıfı parametresini içine vererek Category sınıfı için yapıyoruz.
        public List<Category> GetAll()
        {
            return repoCategory.List();//Repository sınıfını Category için çağırarak böylece içindeki methodları kullanabilmemi
            //sağladı . İçindeki List() metodunu çağırdım. Burada o metodu uygular.
        }



    }
}
