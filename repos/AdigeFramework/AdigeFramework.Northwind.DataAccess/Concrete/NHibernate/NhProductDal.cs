using AdigeFramework.DataAccess.NHibernate;
using AdigeFramework.Northwind.DataAccess.Abstract;
using AdigeFramework.Northwind.Entities.ComplexTypes;
using AdigeFramework.Northwind.Entities.Concrete;
using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 

namespace AdigeFramework.Northwind.DataAccess.Concrete.NHibernate
{
   public class NhProductDal:NhEntityRepositoryBase<Product>,IProductDal
    {
        private NHibernateHelper _nHibernateHelper;
        public NhProductDal(NHibernateHelper nHibernateHelper): base(nHibernateHelper)
        {
            _nHibernateHelper = nHibernateHelper;

        }

        public List<ProductDetail> GetProductDetails()
        {
            using (var session= _nHibernateHelper.OpenSession())
            {
                var result = from p in session.Query<Product>()
                             join c in session.Query<Category>() on p.CategoryId equals c.CategoryID
                             select new ProductDetail
                             {
                                 ProductID = p.ProductId,
                                 ProductName = p.ProductName,
                                 CategoryName = c.CategoryName
                             };
                return result.ToList();
            }
        }
    }
}
