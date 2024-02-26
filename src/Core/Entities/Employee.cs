namespace Core.Entities
{
    public class Employee
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime CheckedDate { get; set; }

        public ICollection<Position> Positions { get; set; }

    }
}
