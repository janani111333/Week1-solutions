using NUnit.Framework;
using LeapYearCalculatorLib;

namespace CalcLibrary.Tests
{
    [TestFixture]
    public class LeapYearCalculatorTests
    {
        private LeapYearCalculator calc;

        [SetUp]
        public void Setup()
        {
            calc = new LeapYearCalculator();
        }

        [TestCase(2020, 1)]     // Leap year
        [TestCase(2000, 1)]     // Leap year (div by 400)
        [TestCase(1900, 0)]     // Not a leap year
        [TestCase(2023, 0)]     // Not a leap year
        [TestCase(1700, -1)]    // Invalid year
        [TestCase(10000, -1)]   // Invalid year
        public void CheckLeapYear_TestCases_ReturnsExpectedResult(int year, int expected)
        {
            var result = calc.CheckLeapYear(year);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
