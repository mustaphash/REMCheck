using Core.Entities;
using Core.Queries;
using Microsoft.EntityFrameworkCore;

namespace DAL.Queries.GetEmployeeById
{
    public class GetEmployeeByIdQueryHandler : IQueryHandler<GetEmployeeByIdQuery, Employee>
    {
        private readonly REMContext _rEMContext;

        public GetEmployeeByIdQueryHandler(REMContext rEMContext)
        {
            _rEMContext = rEMContext;
        }

        public async Task<Employee> HandleAsync(GetEmployeeByIdQuery query, CancellationToken cancellationToken = default)
        {
            var employee = await _rEMContext.Employees.FirstOrDefaultAsync(e => e.Id == query.Id, cancellationToken);

            return employee;
        }
    }
}
