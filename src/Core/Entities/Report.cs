namespace Core.Entities
{
    public class Report : Employee
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public ICollection<Employee> Employees { get; set; }

    }
}
