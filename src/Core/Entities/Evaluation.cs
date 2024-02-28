namespace Core.Entities
{
    public class Evaluation : Employee
    {
        public decimal Precent { get; set; }

        public string Description { get; set; }

        public int EmployeeId { get; set; }
    }
}
