using NUnit.Framework;
using Moq;
using ConverterLib;

namespace CalcLibrary.Tests
{
    [TestFixture]
    public class ConverterTests
    {
        [Test]
        public void USDToEuro_ValidRateAndAmount_ReturnsExpectedEuro()
        {
            // Arrange: Create mock exchange rate provider
            var mockRateFeed = new Mock<IDollarToEuroExchangeRateFeed>();
            mockRateFeed.Setup(x => x.GetExchangeRate()).Returns(0.85);

            var converter = new Converter(mockRateFeed.Object);

            // Act
            double result = converter.USDToEuro(100);

            // Assert
            Assert.That(result, Is.EqualTo(85));
        }

        [Test]
        public void USDToEuro_ZeroAmount_ReturnsZero()
        {
            var mockRateFeed = new Mock<IDollarToEuroExchangeRateFeed>();
            mockRateFeed.Setup(x => x.GetExchangeRate()).Returns(0.85);

            var converter = new Converter(mockRateFeed.Object);

            double result = converter.USDToEuro(0);

            Assert.That(result, Is.EqualTo(0));
        }
    }
}
