using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SchoolProject.Models;

namespace SchoolProject.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult LogIn(LogInViewModel model)
        {
            if (model.UserName=="mohammadfr78@yahoo.com" && model.PassWord == "123")
            {
                return RedirectToAction("index", "home");
            }
            return RedirectToAction("Login");
        }
    }
}