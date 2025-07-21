using NUnit.Framework;
using CollectionsLib;
using System.Linq;

namespace CalcLibrary.Tests
{
    [TestFixture]
    public class EmployeeManagerTests
    {
        private EmployeeManager manager;

        [SetUp]
        public void Setup()
        {
            manager = new EmployeeManager();
        }

        [Test]
        public void GetEmployees_ShouldNotContainNulls()
        {
            var employees = manager.GetEmployees();
            Assert.That(employees, Is.All.Not.Null);
        }

        [Test]
        public void GetEmployees_ShouldContainEmployeeWithId100()
        {
            var employees = manager.GetEmployees();
            Assert.That(employees.Any(e => e.Id == 100), Is.True);
        }

        [Test]
        public void GetEmployees_ShouldHaveUniqueEmployees()
        {
            var employees = manager.GetEmployees();
            var uniqueEmployees = employees.Distinct().ToList();
            Assert.That(uniqueEmployees.Count, Is.EqualTo(employees.Count));
        }

        [Test]
        public void CompareTwoEmployeeLists_ShouldBeEqual()
        {
            var list1 = manager.GetEmployees();
            var list2 = manager.GetEmployeesWhoJoinedInPreviousYears();

            Assert.That(list1, Is.EquivalentTo(list2));
        }
    }
}
