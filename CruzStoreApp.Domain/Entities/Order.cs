using System;
using System.Collections.Generic;
using Cruz1974Course.Domain.Enums;

namespace Cruz1974Course.Domain.Entities
{
    class Order
    {
        public Order(Customer customer)
        {
            Customer = customer;
            Number = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 8).ToUpper();
            CreateDate = DateTime.Now;
            Status = EOrdemStatus.Created;
            Items = new List<OrderItem>();
            Deliveries = new List<Delivery>();

        }

        public Customer Customer { get; private set; }

        public string Number { get; private set; }

        public DateTime CreateDate { get; private set; }

        public EOrdemStatus Status { get; private set; }

        public IReadOnlyCollection<OrderItem> Items { get; private set; }

        public IReadOnlyCollection<Delivery> Deliveries { get; private set; }

        public void Place()
        {
            Console.WriteLine("Place");
        }

        public void AddItem(OrderItem item)
        {

        }

    }
}
