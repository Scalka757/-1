using CMS.BusinessLayer;

namespace CMS.DataAccess
{
    public class ProductRepository : IProductRepository
    {
        public Product Retrieve(int productId)
        {
            // TODO: Replace with database query.
            return new Product(productId);
        }

        public bool Save(Product product)
        {
            // TODO: Replace with INSERT/UPDATE.
            return product != null;
        }
    }
}
