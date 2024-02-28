using Core.Entities;

namespace REMCheck.Models.EmployeeModels
{
    public class EmployeeResponseModel
    {
        public EmployeeResponseModel(Employee employee)
        {
            Id = employee.Id;
            FirstName = employee.FirstName;
            LastName = employee.LastName;
            CheckedDate = DateTime.Now;
        }

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime CheckedDate { get; set; }
    }
}
