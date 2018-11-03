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
        private readonly SuperSuperContext _context;

        //Define and add default customer, admin, products and purcheses, on Home load, in order to have full db
        private void DefineDefaultProducts()
        {
            //users
            Customer customer = new Customer { UserName = "customer", Address = "Israel", EmailAddress = "Yarden@gmail.com", Password = "customer", confirmPassword = "customer" };
            Admin admin = new Admin { Name = "admin", Password = "admin"};

            //products
            Product p1 = new Product { Name = "Milk 3% Tnuva", Calories = 200, Diet = false, Kosher = true, Price = 5.80, Supplier = "Shupersal", category = Models.Product.Category.Dairy };
            Product p2 = new Product { Name = "Milk 3% Tnuva", Calories = 200, Diet = false, Kosher = true, Price = 5.90, Supplier = "Tiv Taam", category = Models.Product.Category.Dairy };
            Product p3 = new Product { Name = "Milk 3% Tnuva", Calories = 200, Diet = false, Kosher = true, Price = 6.00, Supplier = "Super Yehuda", category = Models.Product.Category.Dairy };
            Product p4 = new Product { Name = "Milk 1% Tnuva", Calories = 100, Diet = false, Kosher = true, Price = 5.80, Supplier = "Shupersal", category = Models.Product.Category.Dairy };
            Product p5 = new Product { Name = "Milk 2% Tnuva", Calories = 120, Diet = false, Kosher = true, Price = 6.10, Supplier = "Shupersal", category = Models.Product.Category.Dairy };

            Product p6 = new Product { Name = "Shugi", Calories = 800, Diet = false, Kosher = true, Price = 22.80, Supplier = "Shupersal", category = Models.Product.Category.Cupboard };
            Product p7 = new Product { Name = "Shugi", Calories = 800, Diet = false, Kosher = true, Price = 23.00, Supplier = "Tiv Taam", category = Models.Product.Category.Cupboard };
            Product p8 = new Product { Name = "Brenflacks", Calories = 600, Diet = true, Kosher = true, Price = 27.30, Supplier = "Shupersal", category = Models.Product.Category.Cupboard };
            Product p9 = new Product { Name = "Brenflacks", Calories = 600, Diet = true, Kosher = true, Price = 28.90, Supplier = "Tiv Taam", category = Models.Product.Category.Cupboard };

            Product p10 = new Product { Name = "Bamba Osem", Calories = 1500, Diet = false, Kosher = true, Price = 5.80, Supplier = "Shupersal", category = Models.Product.Category.Snacks };
            Product p11 = new Product { Name = "Bamba Osem", Calories = 1500, Diet = false, Kosher = true, Price = 5.80, Supplier = "Tiv Taam", category = Models.Product.Category.Snacks };

            Product p12 = new Product { Name = "Coca Cola", Calories = 400, Diet = false, Kosher = true, Price = 7.10, Supplier = "Shupersal", category = Models.Product.Category.Drinks };
            Product p13 = new Product { Name = "Coca Cola Zero", Calories = 0, Diet = true, Kosher = true, Price = 7.10, Supplier = "Shupersal", category = Models.Product.Category.Drinks };

            Product p14 = new Product { Name = "Ice Cream Nestle Vanilla", Calories = 2000, Diet = false, Kosher = true, Price = 32.00, Supplier = "Super Yehuda", category = Models.Product.Category.Frozen };
            Product p15 = new Product { Name = "Apple Pink Laidy - 1 KG", Calories = 900, Diet = false, Kosher = true, Price = 3.40, Supplier = "Shupersal", category = Models.Product.Category.Fruits };
            Product p16 = new Product { Name = "Organic Tomatos - 1 KG", Calories = 10, Diet = false, Kosher = true, Price = 5.90, Supplier = "Super Yehuda", category = Models.Product.Category.Vegetables };
            Product p17 = new Product { Name = "Toilet Paper", Diet = false, Kosher = true, Price = 16.20, Supplier = "Shupersal", category = Models.Product.Category.Toiltries };

            //Purchases
            Purcheses pu1 = new Purcheses { CustomerId = 1, ProductId = 1, PurchesDate = DateTime.Now, Purchesed = true };
            Purcheses pu2 = new Purcheses { CustomerId = 1, ProductId = 2, PurchesDate = DateTime.Now, Purchesed = true };
            Purcheses pu3 = new Purcheses { CustomerId = 1, ProductId = 3, PurchesDate = DateTime.Now, Purchesed = true };
            Purcheses pu4 = new Purcheses { CustomerId = 1, ProductId = 4, PurchesDate = DateTime.Now, Purchesed = true };
            Purcheses pu5 = new Purcheses { CustomerId = 1, ProductId = 5, PurchesDate = DateTime.Now, Purchesed = true };
            Purcheses pu6 = new Purcheses { CustomerId = 1, ProductId = 6, PurchesDate = DateTime.Now, Purchesed = true };
            Purcheses pu7 = new Purcheses { CustomerId = 1, ProductId = 7, PurchesDate = DateTime.Now, Purchesed = true };
            Purcheses pu8 = new Purcheses { CustomerId = 1, ProductId = 7, PurchesDate = DateTime.Now, Purchesed = true };
            Purcheses pu9 = new Purcheses { CustomerId = 1, ProductId = 7, PurchesDate = DateTime.Now, Purchesed = true };
            Purcheses pu10 = new Purcheses { CustomerId = 1, ProductId = 7, PurchesDate = DateTime.Now, Purchesed = true };

            //if there is no customer in Customer db, add it - will be added only once
            if (!(_context.Customer.Any(u => u.UserName.Equals("customer"))))
            {
                _context.Customer.Add(customer);
                _context.SaveChanges();
            }

            //if there is no admin in Admin db, add it - will be added only once
            if (!(_context.Admin.Any(u => u.Name.Equals("admin"))))
            {
                _context.Admin.Add(admin);
                _context.SaveChanges();
            }

            //if products table is empty - add products
            if (_context.Product.Count() < 1)
            {
                _context.Product.Add(p1); _context.Product.Add(p2); _context.Product.Add(p3); _context.Product.Add(p4); _context.Product.Add(p5); _context.Product.Add(p6);
                _context.Product.Add(p7); _context.Product.Add(p8); _context.Product.Add(p9); _context.Product.Add(p10); _context.Product.Add(p11);
                _context.Product.Add(p12); _context.Product.Add(p13); _context.Product.Add(p14); _context.Product.Add(p15); _context.Product.Add(p16); _context.Product.Add(p17);
                _context.SaveChanges();
            }

            //if product table is not empty and purcheses table IS empty - add purheses
            if ((_context.Purcheses.Count() < 1) && (_context.Product.Count() > 1))
            {
                _context.Purcheses.Add(pu1); _context.Purcheses.Add(pu2); _context.Purcheses.Add(pu3); _context.Purcheses.Add(pu4);
                _context.Purcheses.Add(pu5); _context.Purcheses.Add(pu6); _context.Purcheses.Add(pu7); _context.Purcheses.Add(pu8);
                _context.Purcheses.Add(pu9); _context.Purcheses.Add(pu10);
                _context.SaveChanges();
            }
        }

        public HomeController(SuperSuperContext context)
        {
            _context = context;
            DefineDefaultProducts();

        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult register()
        {
            return RedirectToAction("register", "Customers");
        }

        public IActionResult login()
        {
            return RedirectToAction("login", "Customers");
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

        public IActionResult ml()
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
	
