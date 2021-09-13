using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    //Blok için gereken Category classım
    public class Category//her yerden erişebilmek için erişim belirtecini public yapmalıyız.
    {
        [Key]
        public int CategoryID { get; set; }
        [StringLength(30)]
        public string CategoryName { get; set; }
        //şimdi ilişkiler kuralım. Bireçok ilişki olacak Bir kategori birden çok blog içinde yer alabilir.
        public ICollection<Blog> Blogs { get; set; }//Blog sınıfı ile ilişikisini kurdum.Şimdi bu ilişkiyi Blog içinde yapalım

    }
}
