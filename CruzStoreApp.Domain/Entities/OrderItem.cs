using Cruz1974Course.Domain.Contracts;

namespace Cruz1974Course.Domain.Entities
{
    public class OrderItem : Entity 
    {
        public OrderItem(Product product, decimal quantity)
        {
            Product = product;
            Quantity = quantity;
            Price = product.Price;

            
        }

        public Product Product { get; private set; }

        public decimal Quantity { get; private set; }

        public decimal Price { get; private set; }

    }
}
