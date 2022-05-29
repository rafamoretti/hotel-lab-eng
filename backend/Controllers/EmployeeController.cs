using Assets;
using Microsoft.AspNetCore.Mvc;
using Model;
using Model.VewModels;
using Repository.RepositoryInterfaces;
using ViewModels;

namespace Controllers
{
    [ApiController]
    [Route("v1")]
    public class EmployeeControllers : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly ILoginRepository _loginRepository;
        private readonly IClassReader _classReader;

        public EmployeeControllers(IEmployeeRepository employeeRepository, ILoginRepository loginRepository, IClassReader classReader)
        {
            _employeeRepository = employeeRepository;
            _loginRepository = loginRepository;
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

        [HttpGet]
        [Route("employee/auth")]
        public IActionResult EmployeeLogin(
            [FromBody] LoginViewModel login
        )
        {
            if (login == null)
                return BadRequest();

            var employeeLogin = _classReader.ClassMapper<Employee, LoginViewModel>(login);
            var auth = _loginRepository.GetEmployeeLogin(employeeLogin);

            if (auth != false)
                return Ok();

            return BadRequest();
        }
    }
}