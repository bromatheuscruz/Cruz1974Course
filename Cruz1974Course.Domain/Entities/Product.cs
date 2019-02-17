
using Cruz1974Course.Domain.Contracts;

namespace Cruz1974Course.Domain.Entities
{
    public class Product : Entity
    {

        public Product(
            string title,
            string description,
            string image,
            decimal price,
            decimal quantityOnHand
            )
        {
            Title = title;
            Description = description;
            Image = image;
            Price = price;
            QuantityOnHand = quantityOnHand;
        }

        public string Title { get; private set; }

        public string Description { get; private set; }

        public string Image { get; private set; }

        public decimal Price { get; private set; }

        public decimal QuantityOnHand { get; private set; }

    }
}
