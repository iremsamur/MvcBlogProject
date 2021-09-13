using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    //Blog sınıfı
    public class Blog
    {
        [Key]
        public int BlogID { get; set; }
        [StringLength(100)]
        public string BlogTitle { get; set; }
        [StringLength(100)]
        public string  BlogImage { get; set; }
        public DateTime BlogDate { get; set; }
        public string BlogContent { get; set; }
        //Kategori ve Blog ilişkisi
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }//Böylece kategori ve bloglar ilişkili hala geldi.

        //Blog ve Yazar ilişkisi
        public int AuthorID { get; set; }
        public virtual Author Author { get; set; }
        //Blog-Yorum ilişkisi
        public ICollection<Comment> Comments { get; set; }//Bir bloğun birden çok yorumu olabilir.

    }
}
