namespace Core.Entities
{
    public class Evaluation : Employee
    {
        public decimal Percent { get; set; }

        public string Description { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}
