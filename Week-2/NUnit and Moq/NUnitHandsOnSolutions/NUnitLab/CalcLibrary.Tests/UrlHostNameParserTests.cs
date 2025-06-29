using NUnit.Framework;
using UtilLib;

namespace CalcLibrary.Tests
{
    [TestFixture]
    public class UrlHostNameParserTests
    {
        private UrlHostNameParser parser;

        [SetUp]
        public void Setup()
        {
            parser = new UrlHostNameParser();
        }

        [Test]
        public void ParseHostName_ValidHttpUrl_ReturnsHost()
        {
            var result = parser.ParseHostName("http://example.com/page");
            Assert.That(result, Is.EqualTo("example.com"));
        }

        [Test]
        public void ParseHostName_ValidHttpsUrl_ReturnsHost()
        {
            var result = parser.ParseHostName("https://google.com/search");
            Assert.That(result, Is.EqualTo("google.com"));
        }

        [Test]
        public void ParseHostName_InvalidUrl_ReturnsInvalidUrl()
        {
            var result = parser.ParseHostName(null!);
            Assert.That(result, Is.EqualTo("Invalid URL"));
        }

        [Test]
        public void ParseHostName_UnknownFormat_ReturnsUnknownFormat()
        {
            var result = parser.ParseHostName("ftp://server.com");
            Assert.That(result, Is.EqualTo("Unknown format"));
        }
    }
}
