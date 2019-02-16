using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cruz1974Course.Domain.Entities;
using Cruz1974Course.Domain.ValueObjects;

namespace Cruz1974CourseTest
{
    [TestClass]
    class UnitTest
    {

        [TestMethod]
        public void TestMethod()
        {
            // Customer
            var myName = new Name("Matheus", "Cruz");
            var myDocument = new Document("123456789-10");
            var myEmail = new Email("bromatheuscruz@gmail.com");
            var myCustomer = new Customer(myName, myDocument, myEmail, "21987654321");

            // Products
            var mouse = new Product("Moude", "Mouse", "mouse.png", 29.90m, 10);
            var teclado = new Product("Teclado", "Teclado", "teclado.png", 30.90m, 5);
            var monitor = new Product("Monitor", "Monitor", "monitor.png", 129.90m, 2);
            
            // Order
            var myOrder = new Order(myCustomer);

            // OrderItems
            myOrder.AddItem(new OrderItem(mouse, 1));
            myOrder.AddItem(new OrderItem(teclado, 1));
            myOrder.AddItem(new OrderItem(monitor, 1));

            // Order methods
            myOrder.Place();
            myOrder.Pay();
            myOrder.Cancel();

        }
    }
}
