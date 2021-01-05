using AdigeFramework.DataAccess;
using AdigeFramework.Northwind.Entities.ComplexTypes;
using AdigeFramework.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdigeFramework.Northwind.DataAccess.Abstract
{
   public interface IProductDal:IEntityRepository<Product>
    {
        //Burada IProductaDal da ürüne özgü metotlarımız olabilir. O yüzden böyle bir katman yazdık
        List<ProductDetail> GetProductDetails();
    }
}
