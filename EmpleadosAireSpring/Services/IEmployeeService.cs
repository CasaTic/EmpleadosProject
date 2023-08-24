using EmpleadosAireSpring.Models;

namespace EmpleadosAireSpring.Services
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetAllEmployees();
        Employee GetEmployeeByID(int employeeID);
        void AddEmployee(Employee employee);
        // Otras operaciones según necesidad
    }
}
