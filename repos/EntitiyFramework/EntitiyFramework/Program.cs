using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new DatabaseFirstEntities();
            var newPost = new Post()
            {
                Id = 0,
                Title = "Hello ef",
                Detail = "ef ye giriiş",
                PublishedDate = DateTime.Now
            };
            context.Post.Add(newPost);
            context.SaveChanges();
            Console.ReadKey();
        }
    }
}
