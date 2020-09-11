using Microsoft.AspNetCore.Mvc;
using WebAPIwithOracleDapper.Model;

namespace WebAPIwithOracleDapper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class EmployeesController : ControllerBase
    {
        IEmployeeRepository employeeRepository;
        public EmployeesController(IEmployeeRepository _employeeRepository)
        {
            employeeRepository = _employeeRepository;
        }

        [Route("api/GetEmployeeList")]
        public ActionResult GetEmployeeList()
        {
            var result = employeeRepository.GetEmployeeList();
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [Route("api/GetEmployeeDetails/{empId}")]
        public ActionResult GetEmployeeDetails(int empId)
        {
            var result = employeeRepository.GetEmployeeDetails(empId);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
    }
}