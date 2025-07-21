namespace CollectionsLib
{
    public class EmployeeManager
    {
        public List<Employee> GetEmployees()
        {
            return new List<Employee>
            {
                new Employee { Id = 100, Name = "Alice" },
                new Employee { Id = 101, Name = "Bob" },
                new Employee { Id = 102, Name = "Charlie" }
            };
        }

        public List<Employee> GetEmployeesWhoJoinedInPreviousYears()
        {
            return new List<Employee>
            {
                new Employee { Id = 100, Name = "Alice" },
                new Employee { Id = 101, Name = "Bob" },
                new Employee { Id = 102, Name = "Charlie" }
            };
        }
    }
}
