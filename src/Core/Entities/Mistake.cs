namespace Core.Entities
{
    public class Mistake : Employee
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public Employee Employee { get; set; }
    }
}
