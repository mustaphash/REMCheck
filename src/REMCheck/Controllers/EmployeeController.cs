using Core.Entities;
using Core.Queries;
using DAL.Queries.GetEmployeeById;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace REMCheck.Controllers
{
    [Route("employees")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IQueryHandler<GetEmployeeByIdQuery, Employee> _getEmployeeByIdQuery;

        public EmployeeController(
            IQueryHandler<GetEmployeeByIdQuery, Employee> getEmployeeByIdQuery)
        {
            _getEmployeeByIdQuery = getEmployeeByIdQuery;
        }

        [HttpGet]


    }
}
