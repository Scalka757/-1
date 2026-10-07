namespace CMS.BusinessLayer
{
    public interface IOrderItemRepository
    {
        OrderItem Retrieve(int orderItemId);
        bool Save(OrderItem orderItem);
    }
}
