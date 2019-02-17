using Cruz1974Course.Domain.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cruz1974Course.Test.ValueObjects
{   
    [TestClass]
    public class EmailTest
    {
        private Email _invalidEmail;
        private Email _validEmail;

        public EmailTest()
        {
            _invalidEmail = new Email("emailinvalido@");
            _validEmail = new Email("meuemail@gmail.com");
        }

        [TestMethod]
        public void ShouldReturnNotificationWhenEmailIsInvalid()
        {
            Assert.AreEqual(false, _invalidEmail.IsValid);
            Assert.AreEqual(1, _invalidEmail.Notifications.Count);
        }

        [TestMethod]
        public void ShouldReturnNotNotificationWhenEmailIsValid()
        {
            Assert.AreEqual(true, _validEmail.IsValid);
            Assert.AreEqual(0, _validEmail.Notifications.Count);

        }


    }
}
