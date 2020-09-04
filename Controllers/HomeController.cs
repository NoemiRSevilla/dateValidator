using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dateValidator.Models;

namespace dateValidator.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {

            return View();
        }
        [HttpPost("register")]
        public IActionResult Register(Date newDate)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Submit");
            }
            else
            {
                return View("Index");
            }
        }
        [HttpGet("submit")]
        public IActionResult Submit()
        {
            return View();
        }
    }
}