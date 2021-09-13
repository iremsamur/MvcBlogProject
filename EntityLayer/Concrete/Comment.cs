using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Comment
    {
        [Key]
        public int CommentID { get; set; }
        [StringLength(50)]
        public string UserName { get; set; }
        [StringLength(50)]
        public string Mail { get; set; }
        [StringLength(300)]
        public string CommentText { get; set; }
        //Blog-Comment ilişkisi
        public int BlogID { get; set; }
        public virtual Blog Blog{ get; set; }

    }
}
