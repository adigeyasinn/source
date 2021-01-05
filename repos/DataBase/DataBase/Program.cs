using System;
using System.Xml.Linq;

namespace DataBase
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = XElement.Load(@"D:\Books.xml");
            var booklist = books.Elements();

            foreach (var item in booklist)
            {

                Console.WriteLine($"{item.Element("title").Value,-15}" +
                    $"{item.Element("price").Value,-10}");

            }

            Console.ReadKey();
        }
    }
}
