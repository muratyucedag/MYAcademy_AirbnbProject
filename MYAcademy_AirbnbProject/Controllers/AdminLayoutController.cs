using Microsoft.AspNetCore.Mvc;

namespace MYAcademy_AirbnbProject.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}