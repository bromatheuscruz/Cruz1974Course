using System;
using System.Collections.Generic;
using Cruz1974Course.Domain.Enums;
using System.Linq;

namespace Cruz1974Course.Domain.Entities
{
    public class Order
    {
        #region actions

        private readonly Action<Delivery> ShipDeliveries = x => x.Ship();
        private readonly Action<Delivery> CancelDeliveries = x => x.Cancel();

        #endregion

        #region private attr

        private readonly IList<OrderItem> _items;
        private readonly IList<Delivery> _deliveries;
        private readonly int estimatedDeliveryDateDefault = 5;
        private readonly int quantityOfItemsPerOrder = 5;

        #endregion

        #region ctor

        public Order(Customer customer)
        {
            Customer = customer;
            CreateDate = DateTime.Now;
            Status = EOrdemStatus.Created;
            _items = new List<OrderItem>();
            _deliveries = new List<Delivery>();

        }

        #endregion

        #region props

        public Customer Customer { get; private set; }

        public string Number { get; private set; }

        public DateTime CreateDate { get; private set; }

        public EOrdemStatus Status { get; private set; }

        public IReadOnlyCollection<OrderItem> Items => _items.ToArray();

        public IReadOnlyCollection<Delivery> Deliveries => _deliveries.ToArray();

        #endregion

        #region methods

        public void Place()
        {
            Number = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 8).ToUpper();
        }

        public void Pay()
        {
            Status = EOrdemStatus.Paid;
           
        }

        public void Ship()
        {
            var deliveries = new List<Delivery>();
            var count = 1;

            foreach (var item in Items)
            {
                if (count == quantityOfItemsPerOrder)
                {
                    count = 0;
                    deliveries.Add(new Delivery(DateTime.Now.AddDays(estimatedDeliveryDateDefault)));
                }
                count++;
            }

            deliveries.ForEach(ShipDeliveries);
            deliveries.ForEach(x => _deliveries.Add(x));
        }

        public void Cancel()
        {
            Status = EOrdemStatus.Canceled;
            _deliveries.ToList().ForEach(CancelDeliveries);

        }


        public void AddItem(OrderItem item)
        {
            _items.Add(item);
        }

        public void AddDelivery(Delivery delivery)
        {
            _deliveries.Add(delivery);
        }

        #endregion

    }
}