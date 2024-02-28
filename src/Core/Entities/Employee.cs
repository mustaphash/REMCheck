namespace Core.Entities
{
    public class Employee
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime CheckedDate { get; set; }

        public ICollection<Position> Positions { get; set; }

        public ICollection<Evaluation> Evaluations { get; set; }

        public ICollection<Report> Reports { get; set; }
    }
}
