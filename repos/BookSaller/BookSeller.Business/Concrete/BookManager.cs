using BookSaller.Concrete;
using BookSaller.DataAccess.Abstract;
using BookSeller.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSeller.Business.Concrete
{
    public class BookManager : IBookService
    {
        IBookDal _bookDal; //3 ünü de kullanabilme imkanını verdi(ADONET,Ef,Nh)

       

        public BookManager(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }

        public void Add(Book book)
        {
            _bookDal.Add(book);
        }

        public List<Book> GetAll()
        {
            return _bookDal.GetAll();
        }

        public void Update(Book book)
        {
            _bookDal.Update(book);
        }
    }
}
