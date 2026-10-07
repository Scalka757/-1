namespace CMS.BusinessLayer
{
    public interface IOrderRepository
    {
        Order Retrieve(int orderId);
        bool Save(Order order);
    }
}
