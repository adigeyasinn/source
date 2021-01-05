using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta11_ShoppingCardApp
{
    public class ShoppingContext : DbContext
    {
        public DbSet<Product> Products { get; set; } //nesneyi oluşturup db setini elde ettik

    }
}
