using AdigeFramework.Northwind.DataAccess.Concrete.EntityFramework;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace AdigeFramework.DataAccess.Tests.EntityFramework
{
    [TestClass]
    public class NHibernateTest
    {
        [TestMethod]
        public void Get_all_returns_all_products()
        {
            EfProductDal productDal = new EfProductDal();
            var result = productDal.GetAll();

            Assert.AreEqual(77, result.Count);
        }

        public void Get_all_with_parameters_returns_filtered_products()
        {
            EfProductDal productDal = new EfProductDal();
            var result = productDal.GetAll(p=>p.ProductName.Contains("ab"));

            Assert.AreEqual(4, result.Count);
        }
    }
}
