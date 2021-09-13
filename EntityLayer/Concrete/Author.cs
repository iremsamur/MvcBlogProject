using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    //Yazar sınıfı özellikleri yazarın id,adı,görseli vb. özellikleri vardır.
    public class Author
    {
        [Key]
        public int AuthorID { get; set; }
        [StringLength(50)]
        public string AuthorName { get; set; }
        [StringLength(100)]
        public string AuthorImage { get; set; }
        [StringLength(250)]
        public string AuthorAbout { get; set; }
        //ilişkilerde bir attribute kullanmam
        public ICollection<Blog> Blogs { get; set; }//Yazarlar bloglarla ilişkili her bloğun bir yazarı olabilir. ama bir yazar birden çok blog yazabilir. Yani birden çok blog ilişkisi olabilir. 1'e N ilişki (1'e çok)
    }
}
