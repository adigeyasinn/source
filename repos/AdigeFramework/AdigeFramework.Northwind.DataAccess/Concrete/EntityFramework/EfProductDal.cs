using AdigeFramework.DataAccess.EntityFramework;
using AdigeFramework.Northwind.DataAccess.Abstract;
using AdigeFramework.Northwind.Entities.ComplexTypes;
using AdigeFramework.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AdigeFramework.Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
        //ürünlerimiz ile ilgili işlemleri yazmış olduk
        public List<ProductDetail> GetProductDetails()
        {
            using (var context=new NorthwindContext())
            {
                var result = from o in context.Products
                             join c in context.Categories on o.CategoryId equals c.CategoryID
                             select new ProductDetail
                             {
                                 ProductID = o.ProductId,
                                 ProductName = o.ProductName,
                                 CategoryName = c.CategoryName
                             };
                return result.ToList();
            }
        }
    }
}
