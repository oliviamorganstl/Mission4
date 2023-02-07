using Microsoft.AspNetCore.Mvc;
using Mission4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4.Controllers //Controls which views get submitted where!
{
    public class pagesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
         
        public IActionResult GradeCalc ()
        {
            return View();
        }
        [HttpPost]

        public IActionResult GradeCalc (MyWebsiteModel model)
        {
            return View();
        }
    }
}
