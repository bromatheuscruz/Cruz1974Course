using Cruz1974Course.Shared.Commands;
using System;
using System.Collections.Generic;

namespace Cruz1974Course.Domain.Commands.OrderCommands.Inputs
{
    public class PlaceOrderCommand : ICommand
    {
        PlaceOrderCommand()
        {
            OrderItems = new List<OrderItemCommand>();
        }

        public Guid Customer { get; set; }
        public IList<OrderItemCommand> OrderItems { get; set; }

    }
}
