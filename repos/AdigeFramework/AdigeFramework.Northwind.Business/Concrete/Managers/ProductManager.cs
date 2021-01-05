using AdigeFramework.Aspects.PostSharp;
using AdigeFramework.Aspects.PostSharp.CacheAspect;
using AdigeFramework.Aspects.PostSharp.TransactionAspects;
using AdigeFramework.CrossCuttingConcerns.Caching.Microsoft;
using AdigeFramework.CrossCuttingConcerns.Logging.Loggers;
using AdigeFramework.Northwind.Business.Abstract;
using AdigeFramework.Northwind.Business.Validation_Rules.FluentValidation;
using AdigeFramework.Northwind.DataAccess.Abstract;
using AdigeFramework.Northwind.Entities.Concrete;
using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdigeFramework.Northwind.Business.Concrete.Managers
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal; 
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
            //bunu newlememek için yapıyoruz. Burada I product dal diyerek Entity veya hibernate verebiliriz. Ama bunu yapamzsak
            // alttaki metotların içinde newlemek zorunda kalırız.

        }
        [FluentValidationAspect(typeof(ProductValidator))]
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public Product Add(Product product)
        {
            return _productDal.Add(product);
        }

       [CacheAspect(typeof(MemoryCacheManager))]
       [LogAspect(typeof(DatabaseLogger))]
        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        [FluentValidationAspect(typeof(ProductValidator))]
        public Product GetById(int id)
        {
            return _productDal.Get(p => p.ProductID == id);
        }
        [TransactionScopeAspect]
        public void TransactionalOperation(Product product1, Product product2)
        {
            _productDal.Add(product1);
            //business code
            _productDal.Update(product2);
        }
    }
}
