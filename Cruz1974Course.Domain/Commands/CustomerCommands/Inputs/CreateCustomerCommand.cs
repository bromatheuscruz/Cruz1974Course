
using Cruz1974Course.Shared.Commands;

namespace Cruz1974Course.Domain.Commands.CustomerCommands.Input
{
    public class CreateCustomerCommand : ICommand
    {

        public string FirstName { get;  set; }
        public string LastName { get;  set; }
        public string Document { get;  set; }
        public string Email { get;  set; }
        public string Phone { get;  set; }
        
    }
}
