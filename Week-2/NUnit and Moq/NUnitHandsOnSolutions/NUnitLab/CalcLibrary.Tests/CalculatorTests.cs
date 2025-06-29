using NUnit.Framework;
using CalcLibrary;

namespace CalcLibrary.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator? calc;

        [SetUp]
        public void Init()
        {
            calc = new Calculator();
        }

        [TearDown]
        public void Cleanup()
        {
            calc = null;
        }

        [Test]
        [TestCase(2, 3, 5)]
        [TestCase(10, -4, 6)]
        [TestCase(0, 0, 0)]
        public void Add_TwoNumbers_ReturnsSum(int a, int b, int expected)
        {
            int result = calc!.Add(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(10, 4, 6)]
        [TestCase(5, 5, 0)]
        public void Subtract_TwoNumbers_ReturnsDifference(int a, int b, int expected)
        {
            int result = calc!.Subtract(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(3, 4, 12)]
        [TestCase(0, 10, 0)]
        public void Multiply_TwoNumbers_ReturnsProduct(int a, int b, int expected)
        {
            int result = calc!.Multiply(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(10, 2, 5)]
        [TestCase(9, 3, 3)]
        public void Divide_TwoNumbers_ReturnsQuotient(int a, int b, int expected)
        {
            int result = calc!.Divide(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Divide_ByZero_ThrowsArgumentException()
        {
            try
            {
                calc!.Divide(10, 0);
                Assert.Fail("Division by zero should have thrown an exception.");
            }
            catch (ArgumentException ex)
            {
                Assert.That(ex.Message, Is.EqualTo("Cannot divide by zero"));
            }
        }

        [Test]
        public void TestAddAndClear()
        {
            calc!.AddToResult(5, 10);
            Assert.That(calc.GetResult, Is.EqualTo(15));

            calc.AllClear();
            Assert.That(calc.GetResult, Is.EqualTo(0));
        }
    }
}
