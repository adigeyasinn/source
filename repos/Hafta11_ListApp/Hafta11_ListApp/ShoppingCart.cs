using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta11_ListApp
{
   public class ShoppingCart
    {
        public int NumberOfProductInShopping;
        private List<CartItem> _list { get; set; }
        public ShoppingCart()
        {
            _list = new List<CartItem>();
        }

        public void Add(CartItem item)
        {
            _list.Add(item);
        }

        public void Print()
        {
            Console.WriteLine();
            foreach (var item in _list)
            {
                Console.WriteLine(item.Product.ProductName);
            }

            Console.WriteLine();
        }

        public decimal GetAmount()
        {
            _list.co
        }

        public void Clear()
        {

        }

        public void UpdateQuantity()
        {

        }
    }
}
