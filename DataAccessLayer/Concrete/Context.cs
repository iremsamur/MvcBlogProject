using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        //Entity Layer üzerindeki sınıfları veritabanına oluşturmak için kullandığımız köprü sınıf Context sınıfı olur.
        public DbSet<About> Abouts { get; set; }
        public DbSet<Admin> Admins{ get; set; }//Buradaki isimlendirmede sonuna s takısı alması s takısı alan kısım veritabanında bulunacak s takısı olmayan c#daki sınıf adları olacak.
        //Yani Burada Admin benim c# sınıfım , Admins veritabanı tablo karşılığı
        public DbSet<Author> Authors { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
    }
}
