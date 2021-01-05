using BookSaller.Concrete;
using BookSaller.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSaller.DataAccess.Concrete.NHibernate
{
    public class NhBookDal : IBookDal
    {
        public void Add(Book book)
        {
            throw new NotImplementedException();
        }

        public void Delete(Book t)
        {
            throw new NotImplementedException();
        }

        public Book Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetAll()
        {
            return new List<Book>()
            {
              new Book() { Id = 1, Title = "Nh öğreniyorum", UnitPrice = 50 },
              new Book() { Id = 2, Title = "Nh tasarıyorum", UnitPrice = 60 }

            };
        }

        public void Update(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
