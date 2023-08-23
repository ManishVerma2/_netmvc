using Microsoft.AspNetCore.Mvc;
using WebApp_netmvc.Models;

namespace WebApp_netmvc.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            EmployeeRepository employeeRepository = new EmployeeRepository();
            List<Employee> employees = employeeRepository.GetEmployees();
            return View(employees);
        }
    }
}
