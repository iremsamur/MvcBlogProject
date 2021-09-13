using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BlogManager
    {
        //blog yönetimini , işlemlerini gerçekleştirmek için BlogManager sınıfımı oluşturdum. Category sınıfı için oluşturduğum gibi .Aynısı bu defa Blog sınıfı için olacak
        Repository<Blog> repoBlog = new Repository<Blog>();
        //Blogları listeleme metodu
        public List<Blog> GetAll()
        {
            return repoBlog.List();
        }
    }
}
