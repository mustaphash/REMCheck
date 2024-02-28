using Core.Entities;
using Core.Queries;

namespace DAL.Queries.GetEmployeeById
{
    public class GetEmployeeByIdQuery : IQuery<Employee>
    {
        public GetEmployeeByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; }
    }
}
