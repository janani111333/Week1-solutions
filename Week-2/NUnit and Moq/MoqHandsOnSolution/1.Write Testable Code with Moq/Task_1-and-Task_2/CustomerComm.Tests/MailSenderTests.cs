using NUnit.Framework;
using Moq;
using CustomerCommLib;

namespace CustomerComm.Tests
{
    public class MailSenderTests
    {
        private Mock<IMailSender> _mockMailSender=null!;

        [SetUp]
        public void Setup()
        {
            _mockMailSender = new Mock<IMailSender>();
        }

        [Test]
        public void SendMail_ShouldReturnTrue_WhenMailIsSentSuccessfully()
        {
            // Arrange
            string toAddress = "test@example.com";
            string message = "This is a test message";

            _mockMailSender.Setup(m => m.SendMail(toAddress, message)).Returns(true);

            // Act
            bool result = _mockMailSender.Object.SendMail(toAddress, message);

            // Assert
            Assert.That(result, Is.EqualTo(true));
            _mockMailSender.Verify(m => m.SendMail(toAddress, message), Times.Once);
        }
    }
}
