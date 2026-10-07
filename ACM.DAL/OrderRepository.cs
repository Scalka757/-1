using CMS.BusinessLayer;

namespace CMS.DataAccess
{
    public class OrderRepository : IOrderRepository
    {
        public Order Retrieve(int orderId)
        {
            // TODO: Replace with database query.
            return new Order(orderId);
        }

        public bool Save(Order order)
        {
            // TODO: Replace with INSERT/UPDATE.
            return order != null;
        }
    }
}
