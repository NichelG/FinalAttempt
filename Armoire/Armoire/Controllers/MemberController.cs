﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Armoire.Controllers
{
    public class MemberController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Logout()
        {
            //

            return this.RedirectToAction("Index", "Home");
        }

       

    }
}