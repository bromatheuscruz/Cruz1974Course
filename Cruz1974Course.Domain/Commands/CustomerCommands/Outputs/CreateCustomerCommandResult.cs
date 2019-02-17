using Cruz1974Course.Domain.ValueObjects;
using Cruz1974Course.Shared.Commands;
using System;

namespace Cruz1974Course.Domain.Commands.CustomerCommands.Outputs
{
    public class CreateCustomerCommandResult : ICommandResult
    {
        public CreateCustomerCommandResult(Guid id, string name, string email)
        {

            Id = id;
            Name = name;
            Email = email;

        }

        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

    }
}
