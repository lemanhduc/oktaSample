using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetCore3AuthExample.Models;
using Microsoft.AspNetCore.Authorization;

namespace AspNetCore3AuthExample.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

       [Authorize(Roles="Everyone")]
        public IActionResult Privacy()
        {
            return View();
        }

        [Authorize(Roles="Everyone")]
        public IActionResult Everyone()
        {
        return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
