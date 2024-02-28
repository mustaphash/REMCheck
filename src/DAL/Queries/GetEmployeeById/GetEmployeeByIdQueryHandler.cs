using Core.Entities;
using Core.Queries;
using Microsoft.EntityFrameworkCore;

namespace DAL.Queries.GetEmployeeById
{
    public class GetEmployeeByIdQueryHandler : IQueryHandler<GetEmployeeByIdQuery, Employee>
    {
        private readonly REMContext _remContext;

        public GetEmployeeByIdQueryHandler(REMContext remContext)
        {
            _remContext = remContext;
        }

        public async Task<Employee> HandleAsync(GetEmployeeByIdQuery query, CancellationToken cancellationToken = default)
        {
            var employee = await _remContext.Employees.FirstOrDefaultAsync(e => e.Id == query.Id, cancellationToken);

            return employee;
        }
    }
}
