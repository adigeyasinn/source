using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryADONET
{
    public interface IBook
    {
        void Add(Book book);
        void Update(Book book);
        void Delete(Book book);

        List<Book> GetAll();
    }
}
