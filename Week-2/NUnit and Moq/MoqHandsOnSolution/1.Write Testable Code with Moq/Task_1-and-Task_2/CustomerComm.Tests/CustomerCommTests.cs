using NUnit.Framework;
using Moq;
using CustomerCommLib;


namespace CustomerComm.Tests
{
    [TestFixture]
    public class CustomerCommTests
    {
        private CustomerCommLib.CustomerComm _customerComm=null!;
        private Mock<IMailSender> _mockMailSender=null!;

        [OneTimeSetUp]
        public void Init()
        {
            _mockMailSender = new Mock<IMailSender>();
            _mockMailSender.Setup(m => m.SendMail(It.IsAny<string>(), It.IsAny<string>()))
                           .Returns(true);

            _customerComm = new CustomerCommLib.CustomerComm(_mockMailSender.Object);
        }

        [Test]
        public void SendMailToCustomer_ReturnsTrue()
        {
            bool result = _customerComm.SendMailToCustomer();
            Assert.That(result, Is.True);


        }
    }
}
