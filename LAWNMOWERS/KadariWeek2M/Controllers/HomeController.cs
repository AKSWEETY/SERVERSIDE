using KadariWeek2M.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace KadariWeek2M.Controllers
{
    public class HomeController : Controller
    {
        //created by Kadari
        public IActionResult Index()
        {
            return View();
        }//index
        [HttpPost]
        public IActionResult Index(LawnMowersmodel model) { 
             //if model is valid: return the result view
             // if not return index with  model

            if (ModelState.IsValid)
            {
                //model is valid: user entered all data valid
                //calculate the quote by calling the calculate method of model
                model.Calculate();
                //return the result view along with the model
                return View("Results", model);
            }// end if
            return View(model);
        }//index post

       
    }
}
