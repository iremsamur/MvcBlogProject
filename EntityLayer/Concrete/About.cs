using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    //Classlar veritabanı tablo karşılıklarıdır. İçlerindeki proplar ise tablo sütunlarıdır.
    public class About
    {
        [Key]//sınıf özelliklerine attributeslar ekliyorum.
        public int AboutID { get; set; }
        [StringLength(500)]
        public string AboutContent1 { get; set; }
        [StringLength(500)]
        public string AboutContent2{ get; set; }
        [StringLength(100)]
        public string AboutImage1 { get; set; }
        [StringLength(100)]
        public string AboutImage2 { get; set; }
    }
}
