using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult UserIndex()
        {
            return View();
        }
        public IActionResult RoleIndex()
        {
            return View();
        }

        public IActionResult ModuleIndex()
        {
            return View();
        }

        public IActionResult DutyIndex()
        {
            return View();
        }

    }
}