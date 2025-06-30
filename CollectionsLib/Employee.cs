namespace CollectionsLib
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";

        public override bool Equals(object? obj)
        {
            return obj is Employee emp && this.Id == emp.Id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
