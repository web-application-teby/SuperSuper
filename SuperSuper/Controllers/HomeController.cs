using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using SuperSuper.Models;

namespace SuperSuper.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult register()
        {

            return RedirectToAction("register", "Customers");
            //return View("~/Views/Customers/register.cshtml");
            //return View();
        }

        public IActionResult login()
        {
            return RedirectToAction("login", "Customers");
            //return View("~/Views/Customers/login.cshtml");
            //return View("~/Views/User/chooseUserType.cshtml");
            //return View();
        }

        public IActionResult adminLogin()
        {
            return RedirectToAction("adminLogin", "Admins");
            //return View("~/Views/Admins/adminLogin.cshtml");
            //return View("~/Views/User/chooseUserType.cshtml");
            //return View();
        }

        public IActionResult Product()
        {
            ViewData["Message"] = "Your Products page.";

            return View("~/Views/Products/Create.cshtml");
        }

        public IActionResult Purcheses()
        {
            ViewData["Message"] = "Your Purcheses page.";

            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Map()
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
	
