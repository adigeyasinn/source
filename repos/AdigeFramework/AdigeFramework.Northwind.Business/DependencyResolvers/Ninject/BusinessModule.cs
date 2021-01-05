using AdigeFramework.DataAccess;
using AdigeFramework.DataAccess.EntityFramework;
using AdigeFramework.DataAccess.NHibernate;
using AdigeFramework.Northwind.Business.Abstract;
using AdigeFramework.Northwind.Business.Concrete.Managers;
using AdigeFramework.Northwind.DataAccess.Abstract;
using AdigeFramework.Northwind.DataAccess.Concrete.EntityFramework;
using AdigeFramework.Northwind.DataAccess.Concrete.NHibernate.Helpers;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdigeFramework.Northwind.Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IProductService>().To<ProductManager>().InSingletonScope();
            Bind<IProductDal>().To<EfProductDal>().InSingletonScope();// Bizden IProductDal istediğinde ef productDal getir

            Bind(typeof(IQueryableRepository<>)).To(typeof(EfQueryableRepository<>));
            Bind<DbContext>().To <NorthwindContext>();
            Bind<NHibernateHelper>().To<SqlServerHelper>();
        }
    }
}
