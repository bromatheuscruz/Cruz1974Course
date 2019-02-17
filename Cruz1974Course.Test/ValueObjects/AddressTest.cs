using Cruz1974Course.Domain.Enums;
using Cruz1974Course.Domain.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cruz1974Course.Test.ValueObjects
{
    [TestClass]
    public class AddressTest 
    {
        private Address _invalidAddress;
        private Address _validAddress;
        private int _zeroNotifications = 0;

        public AddressTest()
        {
            _invalidAddress = new Address("", "", "", "", "", "", "", "", EAddressType.Billing);
            _validAddress = new Address("Dos bobos", "S/N", "Uma casa muito engraçada","Bairro" ,"Cidade", "Estado", "Hu3 Hu3 BR", "123456789", EAddressType.Billing);
        }

        [TestMethod]
        public void ShouldReturnNotificationWhenAddressIsInvalid()
        {
            
            Assert.AreEqual(false, _invalidAddress.IsValid);
            Assert.IsTrue(_invalidAddress.Notifications.Count > _zeroNotifications);
            
        }

        [TestMethod]
        public void ShouldReturnNotNotificationWhenAddressIsValid()
        {
            Assert.AreEqual(true, _validAddress.IsValid);
            Assert.AreEqual(_zeroNotifications, _validAddress.Notifications.Count);
        }
    }
}
