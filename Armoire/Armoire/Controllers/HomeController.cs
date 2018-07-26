using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Armoire.Models;
using NHibernate;
using Armoire.Common;
using Armoire.Common.ViewModels;

namespace Armoire.Controllers
{
    public class HomeController : Controller
    {
        private IUserService _userService;

        public HomeController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        [HttpPost]
        public IActionResult Login()
        {
            
            ViewData["Message"] = "Login Page";
            var login = new LoginViewModel();
            return View(login);
        }

        
        public IActionResult Login(LoginViewModel viewModel)
        {
            var message = "Username and/or password does not match or does not exist.";
            if (ModelState.IsValid)
            {
                bool login = _userService.IsUser(viewModel);
                if (login == true)
                {
                    //return View("Index", "Member");//take to dash page
                    return this.RedirectToAction("Index", "Member");
                }

            }

            return View();
        }

        
        public IActionResult Register()
        {
            ViewData["Message"] = "Registration Page";
            var register = new RegisterViewModel();
            return View(register);
           // return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                _userService.Register(viewModel);
            }
            // return View();
            return this.RedirectToAction("Home", "Login");
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
