namespace CMS.BusinessLayer
{
    public interface IProductRepository
    {
        Product Retrieve(int productId);
        bool Save(Product product);
    }
}
