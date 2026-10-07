using CMS.BusinessLayer;

namespace CMS.DataAccess
{
    public class OrderItemRepository : IOrderItemRepository
    {
        public OrderItem Retrieve(int orderItemId)
        {
            // TODO: Replace with database query.
            return new OrderItem(orderItemId);
        }

        public bool Save(OrderItem orderItem)
        {
            // TODO: Replace with INSERT/UPDATE.
            return orderItem != null;
        }
    }
}
