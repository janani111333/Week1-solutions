using NUnit.Framework;
using FourSeasonsLib;
using System.Collections;

namespace CalcLibrary.Tests
{
    [TestFixture]
    public class SeasonServiceTests
    {
        private SeasonService service;

        [SetUp]
        public void Setup()
        {
            service = new SeasonService();
        }

        public static IEnumerable SeasonTestCases
        {
            get
            {
                yield return new TestCaseData("February").Returns("Spring");
                yield return new TestCaseData("March").Returns("Spring");
                yield return new TestCaseData("April").Returns("Summer");
                yield return new TestCaseData("June").Returns("Summer");
                yield return new TestCaseData("August").Returns("Monsoon");
                yield return new TestCaseData("September").Returns("Monsoon");
                yield return new TestCaseData("October").Returns("Autumn");
                yield return new TestCaseData("November").Returns("Autumn");
                yield return new TestCaseData("December").Returns("Winter");
                yield return new TestCaseData("January").Returns("Winter");
                yield return new TestCaseData("RandomMonth").Returns("Unknown");
            }
        }

        [Test, TestCaseSource(nameof(SeasonTestCases))]
        public string GetSeason_ValidMonth_ReturnsCorrectSeason(string month)
        {
            return service.GetSeason(month);
        }
    }
}
