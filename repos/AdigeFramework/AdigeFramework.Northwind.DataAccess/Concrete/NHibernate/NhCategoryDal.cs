using AdigeFramework.DataAccess.NHibernate;
using AdigeFramework.Northwind.DataAccess.Abstract;
using AdigeFramework.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdigeFramework.Northwind.DataAccess.Concrete.NHibernate
{
    public class NhCategoryDal: NhEntityRepositoryBase<Category>,ICategoryDal
    {
        public NhCategoryDal(NHibernateHelper nHibernateHelper):base(nHibernateHelper)
        {
               
        }
    }
}
