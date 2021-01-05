using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta11_ShoppingCardApp
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }

        public override string ToString()
        {
            return $"{ProductName,-15}{UnitPrice,-15}";

        }
    }
