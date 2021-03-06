﻿using Microsoft.AspNetCore.Mvc;
using WebApplicationSample.Models;
using System.Diagnostics;

namespace WebApplicationSample.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Gratuity()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
