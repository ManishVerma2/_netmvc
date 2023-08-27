using Microsoft.AspNetCore.Mvc;
using WebApp_netmvc.Models;

namespace WebApp_netmvc.Controllers
{
    public class StateController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public JsonResult CountryState(int id)
        {
            StateRepository repo = new StateRepository();
            var data = repo.GetStateByCountry(id);
            return Json(data);
        }
    }
}
