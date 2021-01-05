using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDatabaseFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Books() {
                CategoryId = 2,
                Title="Chess"
            
            };
            

            var context = new LibraryDbEntities();
            context.Books.Add(book);
            context.SaveChanges();
            context.Books.ToList().ForEach(o => Console.WriteLine(o.Title));

            Console.ReadKey();
        }
    }
}
