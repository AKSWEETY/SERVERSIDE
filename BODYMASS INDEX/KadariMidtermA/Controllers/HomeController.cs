using KadariMidtermA.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace KadariMidtermA.Controllers
{
    public class HomeController : Controller
    {
        
        //created by Kadari

        public IActionResult Index()
        {
            return View(new BodyMass());
        }
        // ACTION METHOD FOR POST METHOD
        [HttpPost]
        public IActionResult BMI(BodyMass model)
        {
            if (ModelState.IsValid)
            {
                model.Calculatebodymass();
                return View(model);// returns the view

            }
            return View("Index",model); // returns the view and acts as sticky
        }

        
    }
}
