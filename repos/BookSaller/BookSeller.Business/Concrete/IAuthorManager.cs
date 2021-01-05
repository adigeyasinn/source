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
    public class AuthorManager : IAuthorService
    {
        IAuthorDal _authorDal;

        public AuthorManager(IAuthorDal authorDal)
        {
            _authorDal = authorDal;
        }

        public void Add(Author author)
        {
            _authorDal.Add(author);
        }

        public List<Author> GetAll()
        {
            return _authorDal.GetAll();
        }

        public void Update(Author author)
        {
            _authorDal.Update(author);
        }
    }
}
