using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ICategoryDal:IRepository<Category>
        //ICategoryDal demek Data Access Layer'da Category interface'i demektir. Dal : Data Access Layer
    {
    }
}
