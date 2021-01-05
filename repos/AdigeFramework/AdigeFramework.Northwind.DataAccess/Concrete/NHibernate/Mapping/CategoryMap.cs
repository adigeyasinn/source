using AdigeFramework.Northwind.Entities.Concrete;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdigeFramework.Northwind.DataAccess.Concrete.NHibernate.Mapping
{
    public class CategoryMap : ClassMap<Category>
    {
        public CategoryMap()
        {
            Table(@"Categories");
            LazyLoad();

            Id(x => x.CategoryID).Column("CategoryID");
            Map(x => x.CategoryName).Column("CategoryName");
        }
    }
}
