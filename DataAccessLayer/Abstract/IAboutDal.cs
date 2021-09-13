using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IAboutDal:IRepository<About>
        //veritabanı işlemleri için oluşturduğumuz soyut IRepository interface'inden bu interface miras alarak Ve Bunu <> İçine 
        //aldığı T parametresi yerine About somut sınıfı gelir. Yani About Sınıfı için ekleme,silme gibi craud işlemlerini IRepository interface'inden miras al anlamındadır.
        //Bu işlemi EntityLayer'da bulunan her somut sınıf için gerçekleştiririm.
    {
    }
}
