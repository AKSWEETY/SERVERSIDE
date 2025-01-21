using Microsoft.AspNetCore.Mvc;

namespace mule.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
