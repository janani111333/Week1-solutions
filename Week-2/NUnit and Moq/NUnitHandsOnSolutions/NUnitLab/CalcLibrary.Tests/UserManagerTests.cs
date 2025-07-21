using NUnit.Framework;
using UserManagerLib;

namespace CalcLibrary.Tests
{
    [TestFixture]
    public class UserManagerTests
    {
        private UserManager manager;

        [SetUp]
        public void Setup()
        {
            manager = new UserManager();
        }

        [Test]
        public void CreateUser_ValidPAN_ReturnsSuccessMessage()
        {
            var result = manager.CreateUser("ABCDE1234F");
            Assert.That(result, Is.EqualTo("User created successfully"));
        }

        [Test]
        public void CreateUser_NullPAN_ThrowsNullReferenceException()
        {
            var ex = Assert.Throws<NullReferenceException>(() => manager.CreateUser(null!));
            Assert.That(ex.Message, Is.EqualTo("PAN cannot be null or empty."));
        }

        [Test]
        public void CreateUser_EmptyPAN_ThrowsNullReferenceException()
        {
            var ex = Assert.Throws<NullReferenceException>(() => manager.CreateUser(""));
            Assert.That(ex.Message, Is.EqualTo("PAN cannot be null or empty."));
        }

        [Test]
        public void CreateUser_InvalidLengthPAN_ThrowsFormatException()
        {
            var ex = Assert.Throws<FormatException>(() => manager.CreateUser("12345"));
            Assert.That(ex.Message, Is.EqualTo("PAN must be exactly 10 characters."));
        }
    }
}
