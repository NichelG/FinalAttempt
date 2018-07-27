using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Armoire.Controllers
{
    public class MemberSideBarController : Controller
    {
        public IActionResult Account()
        {
            return View();
        }

        public IActionResult MyCloset()
        {
            return View();
        }

        public IActionResult Vote()
        {
            return View();
        }
    }
}