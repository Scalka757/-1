namespace CMS.BusinessLayer
{
    public class OrderItem
    {
        public OrderItem()
        {
        }

        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }

        public int OrderItemId { get; private set; }
        public int OrderQuantity { get; set; }
        public int ProductId { get; set; }
        public decimal? PurchasePrice { get; set; }

        public bool Validate()
        {
            return OrderQuantity > 0
                && ProductId > 0
                && PurchasePrice != null;
        }
    }
}
