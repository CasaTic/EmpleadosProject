using EmpleadosAireSpring.Models;
using EmpleadosAireSpring.Services;
using Microsoft.AspNetCore.Mvc;

namespace EmpleadosAireSpring.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        public ActionResult Index()
        {
            IEnumerable<Employee> employees = (IEnumerable<Employee>)_employeeService.GetAllEmployees();
            return View(employees);
        }

        // Otras acciones según necesidad

    }

}
