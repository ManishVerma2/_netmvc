using Microsoft.AspNetCore.Mvc;
using WebApp_netmvc.Models;

namespace WebApp_netmvc.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentRepository repository;

        public StudentController(IStudentRepository repository)
        {
            this.repository = repository;
        }
        public IActionResult Index()
        {
            List<Student> students = repository.GetStudent();
            return View(students);
        }
    }
}
