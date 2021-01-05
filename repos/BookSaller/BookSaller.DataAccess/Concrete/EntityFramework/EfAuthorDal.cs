using BookSaller.Concrete;
using BookSaller.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSaller.DataAccess.Concrete.EntityFramework
{
    public class EfAuthorDal : EfRepositoryBase<Author, BookSallerContext>, IAuthorDal
    {


    }  
}
