using Assets;
using Microsoft.AspNetCore.Mvc;
using Model;
using Model.VewModels;
using Repository.RepositoryInterfaces;

namespace Controllers
{
    [ApiController]
    [Route("v1")]
    public class EmployeeControllers : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IClassReader _classReader;

        public EmployeeControllers(IEmployeeRepository employeeRepository, IClassReader classReader)
        {
            _employeeRepository = employeeRepository;
            _classReader = classReader;
        }

        [HttpPost]
        [Route("employee")]
        public IActionResult NewEmployee(
            [FromBody] EmployeeViewModel employee
        )
        {
            if (employee == null)
                return BadRequest();

            var employeeAdd = _classReader.ClassMapper<Employee, EmployeeViewModel>(employee);

            if (employeeAdd == null)
                return BadRequest();
            
            _employeeRepository
                .AddEmployee(employeeAdd);

            _employeeRepository
                .Save();

            return Ok();
        }
    }
}