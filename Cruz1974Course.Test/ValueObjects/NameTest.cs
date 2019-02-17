using Cruz1974Course.Domain.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cruz1974Course.Test.ValueObjects
{   
    [TestClass]
    public class NameTest
    {
        private Name _invalidName;
        private Name _validName;

        public NameTest()
        {
            _invalidName = new Name("", "Cruz");
            _validName = new Name("Matheus", "Cruz");
        }

        [TestMethod]
        public void ShouldReturnNotificationWhenNameIsInvalid()
        {
            Assert.AreEqual(false, _invalidName.IsValid);
            Assert.AreEqual(1, _invalidName.Notifications.Count);
        }

        [TestMethod]
        public void ShouldReturnNotNotificationWhenNameIsValid()
        {
            Assert.AreEqual(true, _validName.IsValid);
            Assert.AreEqual(0, _validName.Notifications.Count);
        }
    }
}
