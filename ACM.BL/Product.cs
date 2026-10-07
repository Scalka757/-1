using System;

namespace CMS.BusinessLayer
{
    public class Product
    {
        public Product()
        {
        }

        public Product(int productId)
        {
            ProductId = productId;
        }

        public int ProductId { get; private set; }
        public string ProductDescription { get; set; }
        public string ProductName { get; set; }
        public Decimal? CurrentPrice { get; set; }

        public bool Validate()
        {
            return !string.IsNullOrWhiteSpace(ProductName)
                && CurrentPrice != null;
        }
    }
}
