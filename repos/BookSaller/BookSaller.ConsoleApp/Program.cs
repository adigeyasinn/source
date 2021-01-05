using BookSaller.Concrete;
using BookSaller.DataAccess.Concrete.EntityFramework;
using BookSeller.Business.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSaller.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var authorManager = new AuthorManager(new EfAuthorDal());
            var author = new Author()
            {
                AuthorID = 1,
                FirstName = "Yasin",
                LastName = "Güneş"
            };

            authorManager.Add(author);


            var bookManager = new BookManager(new EfBookDal()); //Burayı ADOnet olarak değiştir veya NhBookdal olarak değiştirebilirsin.
            var book = new Book() { Id = 1, Title = "ef öğreniyorum", UnitPrice = 500,
            Author=author};

            bookManager.Add(book);
            bookManager.GetAll().ForEach(b => Console.WriteLine(b));
            Console.ReadLine();
        }
    }
}
