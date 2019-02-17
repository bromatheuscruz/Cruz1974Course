using Cruz1974Course.Shared.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cruz1974Course.Domain.Commands.OrderCommands.Inputs
{
    public class OrderItemCommand : ICommand 
    {

        public Guid Product { get; set; }
        public decimal Quantity { get; set; }

    }
}
