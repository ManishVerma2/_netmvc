using Microsoft.AspNetCore.Mvc;
using System.Runtime.Intrinsics.Arm;
using WebApp_netmvc.Models;

namespace WebApp_netmvc.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentRepository repository;
        public DepartmentController(IDepartmentRepository repository) // dependency injection
        {
            this.repository = repository;
        }
        public IActionResult Index()
        {
            List<Department> departments=repository.GetDepartments();
            ViewData["Title"] = "Department list";
            ViewData["desc"] ="Department list of sircl tect";

            return View(departments);
        }

        //public IActionResult GetCountry(int id)
        //{
        //    var list = srepository.GetById(id);

        //    return Json(list);
        //}
        public IActionResult Details(int? id)
        {
            Department department=repository.GetDepartmentById(id??10);
            ViewData["Title"] = "Department Detail";

            return View(department);
        }
        [HttpGet]
        public IActionResult Create()
        {
            CountryRepository countryRepository = new CountryRepository();
            ViewBag.Countries = countryRepository.GetAll();
            ViewData["Title"] = "Create New Department";
            return View();
        }
        [HttpPost]
        public IActionResult Create(Department model)
        {
            ViewData["Title"] = "Create New Department";
            Department d1=repository.add(model);
            return RedirectToAction("Detals", new { id = d1.Id });
        }
    }
}
