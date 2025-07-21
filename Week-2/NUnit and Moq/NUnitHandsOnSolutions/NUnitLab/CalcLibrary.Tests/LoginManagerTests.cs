using NUnit.Framework;
using AccountsManagerLib;

namespace CalcLibrary.Tests
{
    [TestFixture]
    public class LoginManagerTests
    {
        private LoginManager loginManager;

        [SetUp]
        public void Setup()
        {
            loginManager = new LoginManager();
        }

        [Test]
        public void Login_ValidUser1_ReturnsWelcomeMessage()
        {
            var result = loginManager.Login("user_11", "secret@user11");
            Assert.That(result, Is.EqualTo("Welcome user_11!!!"));
        }

        [Test]
        public void Login_ValidUser2_ReturnsWelcomeMessage()
        {
            var result = loginManager.Login("user_22", "secret@user22");
            Assert.That(result, Is.EqualTo("Welcome user_22!!!"));
        }

        [Test]
        public void Login_InvalidCredentials_ReturnsErrorMessage()
        {
            var result = loginManager.Login("user_11", "wrongpass");
            Assert.That(result, Is.EqualTo("Invalid user id/password"));
        }

        [Test]
        public void Login_EmptyUserId_ThrowsArgumentException()
        {
            var ex = Assert.Throws<ArgumentException>(() => loginManager.Login("", "pass"));
            Assert.That(ex.Message, Is.EqualTo("User ID and password must not be empty."));
        }

        [Test]
        public void Login_EmptyPassword_ThrowsArgumentException()
        {
            var ex = Assert.Throws<ArgumentException>(() => loginManager.Login("user_11", ""));
            Assert.That(ex.Message, Is.EqualTo("User ID and password must not be empty."));
        }
    }
}
