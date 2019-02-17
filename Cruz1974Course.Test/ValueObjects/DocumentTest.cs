using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cruz1974Course.Domain.ValueObjects;
namespace Cruz1974Course.Test
{
    [TestClass]
    public class DocumentTest
    {
        private Document _validDocument;
        private Document _invalidDocument;

        public DocumentTest()
        {
            // https://www.4devs.com.br/gerador_de_cpf

            _validDocument   = new Document("05360671718");
            _invalidDocument = new Document("1234567890");
        }

        [TestMethod]
        public void ShouldReturnNotificationWhenDocumentIsInvalid()
        {
            Assert.AreEqual(false, _invalidDocument.IsValid);
            Assert.AreEqual(1, _invalidDocument.Notifications.Count);
        }

        [TestMethod]
        public void ShouldReturnNotNotificationWhenDocumentIsValid()
        {
            Assert.AreEqual(true, _validDocument.IsValid);
            Assert.AreEqual(0, _validDocument.Notifications.Count);
        }

    }
}
