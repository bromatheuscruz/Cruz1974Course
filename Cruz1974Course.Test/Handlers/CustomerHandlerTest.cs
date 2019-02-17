using Cruz1974Course.Domain.Commands.CustomerCommands.Input;
using Cruz1974Course.Domain.Handles;
using Cruz1974Course.Test.FakesAndMocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cruz1974Course.Test.Handlers
{   
    [TestClass]
    public class CustomerHandlerTest
    {
        [TestMethod]
        public void ShouldRegisterCustomerCommandIsValid()
        {
            var command = new CreateCustomerCommand();
            command.FirstName = "Matheus";
            command.LastName = "Cruz";
            command.Document = "05360671718";
            command.Email = "hello@cruz.io";
            command.Phone = "21999999999";

            var handler = new CustomerHandler(new FakeCustomerRepository(), new FakeEmailService());
            var result = handler.Handle(command);

            Assert.AreNotEqual(null, result);
            Assert.AreEqual(true, handler.IsValid);
        }
    }
}
