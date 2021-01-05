using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta11_ListApp
{
    public class Product:IComparable<Product>
    {
        public int Id { get; set; } //get okuma,set yazma
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public Product()
        {
            
        }

        public Product(int ıd, string productName, decimal unitPrice)
        {
            Id = ıd;
            ProductName = productName;
            UnitPrice = unitPrice;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public int CompareTo(Product other)
        {
            throw new NotImplementedException();
        }
    }
}
