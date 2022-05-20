using Microsoft.AspNetCore.Mvc;
using Model.VewModels;
using Repository.RepositoryInterfaces;

namespace Controllers
{
    [ApiController]
    [Route("v1")]
    public class EmployeeControllers : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeControllers(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [HttpPost]
        [Route("employee")]
        public IActionResult NewEmployee(
            [FromBody] EmployeeViewModel employee
        )
        {
            
        }
    }
}