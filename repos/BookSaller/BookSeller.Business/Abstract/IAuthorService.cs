using BookSaller.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSeller.Business.Abstract
{
   public interface IAuthorService
    {
        List<Author> GetAll();
        void Add(Author author);
        void Update(Author author);
    }
}
