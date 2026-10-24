using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using Portfolio_With_MVC.Models;

namespace Portfolio_With_MVC.Controllers
{
    public class UserController : Controller
    {
        [HttpGet] 
        public IActionResult Create(int id, string name)
        {
            return View();
        }

        [HttpPost] [ValidateAntiForgeryToken]
        public IActionResult Create(UserModel model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Success", model);
            }

            return View(model);
        }

        public IActionResult Success(UserModel model)
        {
            return View(model);
        }
    }
}