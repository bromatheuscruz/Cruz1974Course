using Cruz1974Course.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cruz1974Course.Domain.Entities
{
    public class Delivery
    {   
        public Delivery(DateTime estimatedDeliveryDate)
        {
            CreateDate = DateTime.Now;
            EstimatedDeliveryDate = estimatedDeliveryDate;
            Status = EDeliveryStatus.Waiting;
        }

        public DateTime CreateDate { get; private set; }

        public DateTime EstimatedDeliveryDate { get; private set; }

        public EDeliveryStatus Status { get; private set; }

        public void Ship()
        {
            Status = EDeliveryStatus.Shipped;
        }

        public void Cancel()
        {
            Status = EDeliveryStatus.Canceled;
        }
    }
}
