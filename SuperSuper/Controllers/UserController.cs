using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SuperSuper.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult chooseUserType()
        {
            // //customer
            //if (User.userType==Customer)
            //    return RedirectToAction("login", "Customer");
            //  //admin
            //else
            //   return RedirectToAction("login", "Admin");

            return View();
        }
    }
}