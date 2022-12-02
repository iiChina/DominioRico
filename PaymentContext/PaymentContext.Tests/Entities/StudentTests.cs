using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests.Entities
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void ShouldReturnErrorWhenHasActiveSubscription()
        {
            var name = new Name("Bruce", "Wayne");
            var document = new Document("26756143000", EDocumentType.CPF);
            var email = new Email("batman@dc.com");
            var student = new Student(name, document,email);

            Assert.Fail();
        }

        public void ShouldReturnSuccessWhenHasNoActiveSubscription()
        {
            Assert.Fail();
        }
    }
}