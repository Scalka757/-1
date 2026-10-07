using Microsoft.VisualStudio.TestTools.UnitTesting;
using CMS.BusinessLayer;
using CMS.DataAccess;

namespace CMS.BusinessLayerTest
{
    [TestClass]
    public class RepositoryTest
    {
        [TestMethod]
        public void CustomerRepositoryRetrievesCustomer()
        {
            ICustomerRepository repository = new CustomerRepository();

            Customer customer = repository.Retrieve(42);

            Assert.AreEqual(42, customer.CustomerId);
        }

        [TestMethod]
        public void ProductRepositorySavesProduct()
        {
            IProductRepository repository = new ProductRepository();
            Product product = new Product(10);

            Assert.IsTrue(repository.Save(product));
        }
    }
}
