using BookSaller.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSaller.DataAccess.Concrete
{
   public class BookSallerContext :  DbContext
    {
        //public BookSallerContext()
        //{
        //    Database.SetInitializer<Book>(null);
        //}
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
