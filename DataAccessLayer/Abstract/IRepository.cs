using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T>//her yerden erişebilmesi için public yaptım.
                                   //interface için T parametresi gönderiyorum. Bu T 'nin anlamı Bu gönderdiğim T parametresine göre craud işlemleri gerçekleştireceğiz
                                   //Bu T parametresi Tüm tablolar sınıflar olabilir. Admin,Category vb. 
                                   //Yani tüm sınıflara , tablolara bu işlemlerin uygulanmasını sağlar. Böylece solid prensibine uygun tasarım ortaya çıkar.
    {
        //Ekeleme,silme,güncelleme vb. veritabanları işlemleri için methodlar.
        List<T> List();
        int Insert(T p);
        int Update(T p);
        int Delete(T p);
        T GetById(int id);//id'sine göre aranan elemanı bulur. 
    }
}
