using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Repository<T> : IRepository<T> where T : class
        //Buradaki Repository sınıfımız generic repository'dir.Biz bu generic repository sınıfını 
        //oluşturunca artık abstractta oluşturduğumuz her sınıf için olan interface'lere gerek kalmadı. (IAuthorDal gibi)
        //Yani aslında ICategoryDal gibi Data Access Layer abstract klasörü içindeki IRepository dışında geri kalan 
        //her sınıf için oluşturulmuş interface'leri oluşturmama hiç gerek yoktu. Direk Bu Repository sınıfını oluşturmam yeterliydi.
    {
        //Benim IRepository'de oluşturduğum methodlarımın karşılığı yok . Bunu oluşturmak için Data Access Layer'da bulunan 
        //Concrete somut sınıfının içinde IRepository interface'inin karşılığı olan somut Repository sınıfını oluştururum. VE interface metodlarını
        //burada implemente ederim.
        //Yani Repository sınıfı içinde bu 5 methoda karşılık gelecek işlevleri yazarım.

        //Bizim sınıflara erişim sağlayabilmemiz için Context sınıfından bir nesne türetmemiz gerekir.
        Context context = new Context();
        DbSet<T> _object;//Burada DbSet türünden olan object bizim dışarıdan göndereceğimiz nesneleri ifade ediyor.

        //Şimdi repository sınıfı için constructor method oluştururuz.
        public Repository()//ctor+2tab - otomatik constructor oluşturur.
        {
            _object = context.Set<T>();//Context üzerinden gönderdiğim sınıfı _object field'ıma atar. Bu object Contact,Blog vb. Yedi sınıfın yediside olabilir. Tüm Entity sınıflarım olabilir.
        }
        public int Delete(T p)//Burada methodlar alfabetik sıralı geldi
        {
            _object.Remove(p);//Gönderdiğim tabloya ait parametre değerini sil
            return context.SaveChanges();//Sildikten sonra değişiklikleri kaydedip contextte göndermiş olduğum sınıftan türeyen bu nesneyi bana geri döndür
        }

        public T GetById(int id)
        {
            return _object.Find(id);//gönderdiğim id değerini objectten bul ve bana geri döndür
            //Bu Find Remove komutları entityframework komutlarıdır. Veritabanı işlemleri böyle yapılır
        }

        public int Insert(T p)
        {
            //Gönderilen değeri ekler.
            _object.Add(p);
            return context.SaveChanges();
        }

        public List<T> List()
        {
            return _object.ToList();//Tüm değerleri bana listele
        }

        public int Update(T p)
        {
            return context.SaveChanges();//Değişiklikleri direk kaydet
        }
        //Böylece Repository sınıfına ait methodların içine object sınıfımıza bağlı olarak ekleme,silme, güncelleme vb. methodlarını eklemiş olduk
    }
}
