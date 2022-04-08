using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using FormSubmission.Models;

namespace FormSubmission.Controllers
{
    public class RegistrationController : Controller
    {
        [HttpGet("")]
        public IActionResult Registration()
        {
            return View("Registration");
        }

        [HttpPost("/register")]
        public IActionResult Register(User user)
        {
            if (!ModelState.IsValid)
            {
                return View("Registration");
            }

            return RedirectToAction("ShowUser", user);
        }

        [HttpGet("/user")]
        public ViewResult ShowUser(User user)
        {
            return View("ShowUser", user);
        }
    }
}