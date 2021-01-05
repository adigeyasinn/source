using BookSaller.Concrete;
using BookSaller.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSaller.DataAccess.Concrete.EntityFramework
{
    class EfCategoryDal: EfRepositoryBase<Category, BookSallerContext>, ICategoryDal
    {
    }
}
