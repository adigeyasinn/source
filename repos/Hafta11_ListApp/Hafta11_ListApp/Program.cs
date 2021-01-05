using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta11_ListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Product>() {
                new Product(1,"Laptop",3500),
                new Product(1,"Laptop11",1500),
                new Product(1,"Laptop22",4500),
                new Product(1,"Laptop33",6500),

            };


            var cartItem1 = new CartItem()
            {
                Product = list[0],
                Quantity = 4
            };

            var shoppingCart = new ShoppingCart();
            shoppingCart.Print();
        }
    }
}
