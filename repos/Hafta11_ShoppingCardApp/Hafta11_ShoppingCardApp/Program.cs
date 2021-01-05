using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta11_ShoppingCardApp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            using (var context=new ShoppingContext())
            {
                var product = new Product()
                {
                    Id = 0,
                    ProductName = "TV",
                    UnitPrice = 3500

                    
                };

                context.Products.Add(product);
                context.SaveChanges();

            }
        }
    }
}
