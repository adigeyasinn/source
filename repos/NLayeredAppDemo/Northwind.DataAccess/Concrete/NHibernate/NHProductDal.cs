﻿using Northwind.DataAccess.Abstract;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Concrete.NHibernate
{
    public class NHProductDal:IProductDal
    {
        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

      

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            List<Product> products = new List<Product> { new Product
            {
                ProductId=1,CategoryId=2,ProductName="Laptop",QuantityPerUnit="1 the box",UnitPrice=3000,UnitsInStock=100
            }


            };
            return products;
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
