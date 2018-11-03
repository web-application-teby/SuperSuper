using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SuperSuper.Models;

namespace SuperSuper.Controllers
{
    public class ProductsController : Controller
    {
        private readonly SuperSuperContext _context;

        Product p1 = new Product { Name = "Milk 3% Tnuva", Calories = 200, Diet = false, Kosher = true, Price = 5.80, Supplier = "Shupersal", category = Product.Category.Dairy };
        Product p2 = new Product { Name = "Milk 3% Tnuva", Calories = 200, Diet = false, Kosher = true, Price = 5.90, Supplier = "Tiv Taam", category = Product.Category.Dairy };
        Product p3 = new Product { Name = "Milk 3% Tnuva", Calories = 200, Diet = false, Kosher = true, Price = 6.00, Supplier = "Super Yehuda", category = Product.Category.Dairy };
        Product p4 = new Product { Name = "Milk 1% Tnuva", Calories = 100, Diet = false, Kosher = true, Price = 5.80, Supplier = "Shupersal", category = Product.Category.Dairy };
        Product p5 = new Product { Name = "Milk 2% Tnuva", Calories = 120, Diet = false, Kosher = true, Price = 6.10, Supplier = "Shupersal", category = Product.Category.Dairy };

        Product p6 = new Product { Name = "Shugi", Calories = 800, Diet = false, Kosher = true, Price = 22.80, Supplier = "Shupersal", category = Product.Category.Cupboard };
        Product p7 = new Product { Name = "Shugi", Calories = 800, Diet = false, Kosher = true, Price = 23.00, Supplier = "Tiv Taam", category = Product.Category.Cupboard };
        Product p8 = new Product { Name = "Brenflacks", Calories = 600, Diet = true, Kosher = true, Price = 27.30, Supplier = "Shupersal", category = Product.Category.Cupboard };
        Product p9 = new Product { Name = "Brenflacks", Calories = 600, Diet = true, Kosher = true, Price = 28.90, Supplier = "Tiv Taam", category = Product.Category.Cupboard };

        Product p10 = new Product { Name = "Bamba Osem", Calories = 1500, Diet = false, Kosher = true, Price = 5.80, Supplier = "Shupersal", category = Product.Category.Snacks };
        Product p11 = new Product { Name = "Bamba Osem", Calories = 1500, Diet = false, Kosher = true, Price = 5.80, Supplier = "Tiv Taam", category = Product.Category.Snacks };

        Product p12 = new Product { Name = "Coca Cola", Calories = 400, Diet = false, Kosher = true, Price = 7.10, Supplier = "Shupersal", category = Product.Category.Drinks };
        Product p13 = new Product { Name = "Coca Cola Zero", Calories = 0, Diet = true, Kosher = true, Price = 7.10, Supplier = "Shupersal", category = Product.Category.Drinks };

        Product p14 = new Product { Name = "Ice Cream Nestle Vanilla", Calories = 2000, Diet = false, Kosher = true, Price = 32.00, Supplier = "Super Yehuda", category = Product.Category.Frozen };
        Product p15 = new Product { Name = "Apple Pink Laidy - 1 KG", Calories = 900, Diet = false, Kosher = true, Price = 3.40, Supplier = "Shupersal", category = Product.Category.Fruits };
        Product p16 = new Product { Name = "Organic Tomatos - 1 KG", Calories = 10, Diet = false, Kosher = true, Price = 5.90, Supplier = "Super Yehuda", category = Product.Category.Vegetables };
        Product p17 = new Product { Name = "Toilet Paper", Diet = false, Kosher = true, Price = 16.20, Supplier = "Shupersal", category = Product.Category.Toiltries };

        public ProductsController(SuperSuperContext context)
        {

            _context = context;

            if (_context.Product.Count() < 1)
            {
                _context.Add(p1);
                _context.Add(p2);
                _context.Add(p3);
                _context.Add(p4);
                _context.Add(p5);
                _context.Add(p6);
                _context.Add(p7);
                _context.Add(p8);
                _context.Add(p9);
                _context.Add(p10);
                _context.Add(p11);
                _context.Add(p12);
                _context.Add(p13);
                _context.Add(p14);
                _context.Add(p15);
                _context.Add(p16);
                _context.Add(p17);
                _context.SaveChanges();
            }
            
        }


        public async Task<IActionResult> Add(int? id)
        {
            try
            {
                int customerId = (int)HttpContext.Session.GetInt32("customerid");
                var customer = await _context.Customer
                .FirstOrDefaultAsync(cu => cu.Id == customerId);
                if (customer == null)
                {
                    return NotFound();
                }

                if (id == null)
                {
                    return NotFound();
                }

                var product = await _context.Product
                    .FirstOrDefaultAsync(m => m.Id == id);
                if (product == null)
                {
                    return NotFound();
                }

                Purcheses p = new Purcheses
                {
                    Product = product,
                    Customer = customer,
                    PurchesDate = DateTime.Now,
                    Purchesed = false
                };

                _context.Purcheses.Add(p);
                _context.SaveChanges();
            }
            catch
            {

                return RedirectToAction("login", "Customers");
                
            }
            


            return RedirectToAction("Index");
        }

        // Post: Products search
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(Product.Category category, bool Diet, string productName)
        {
            //var result = from t in _context.Product select t;

            var enumData = from Product.Category e in Enum.GetValues(typeof(Product.Category))
                           select new
                           {
                               Category = e,
                           };
            ViewBag.EnumList = new SelectList(enumData, "Category", "Category");

            try
            {
                int SessionId = (int)HttpContext.Session.GetInt32("id");
                var admin = _context.Admin.Single(cu => cu.Id == SessionId);
            }
            catch
            {

                var result = from row in _context.Product
                             group row by row.Name into grp
                             select grp.OrderBy(a => a.Price).First();
                if (!string.IsNullOrEmpty(productName))
                {
                    result = result.Where(x => x.Name.Contains(productName));
                }

                if (Diet == true)
                {
                    result = result.Where(x => x.Diet == true);
                }

                if (category != Product.Category.All)
                {
                    result = result.Where(x => x.category.Equals(category));
                }
                return View(await result.ToListAsync());
            }

            var resultAdmin = from row in _context.Product
                              select row;

            if (!string.IsNullOrEmpty(productName))
            {
                resultAdmin = resultAdmin.Where(x => x.Name.Contains(productName));
            }

            if (Diet == true)
            {
                resultAdmin = resultAdmin.Where(x => x.Diet == true);
            }

            if (category != Product.Category.All)
            {
                resultAdmin = resultAdmin.Where(x => x.category.Equals(category));
            }
            return View("IndexAdmin", resultAdmin);
        }


        // GET: Products
        public async Task<IActionResult> Index()
        {
            var enumData = from Product.Category e in Enum.GetValues(typeof(Product.Category))
                           select new
                           {
                               Category = e,
                           };
            ViewBag.EnumList = new SelectList(enumData, "Category", "Category");

            var result = from row in _context.Product
                         group row by row.Name into grp
                         select grp.OrderBy(a => a.Price).First();

            //check if customer or admin
            try
            {
                int SessionId = (int)HttpContext.Session.GetInt32("id");
                var admin = _context.Admin.Single(cu => cu.Id == SessionId);

                var resultAdmin = from row in _context.Product
                                  select row;

                return View("IndexAdmin", resultAdmin);
            }
            catch
            {
                return View(result);
            }

        }

        // GET: Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            ViewData["Title2"] = product.Name;

            return View(product);
        }

        // GET: Products/Create
        public IActionResult Create()
        {
            var enumData = from Product.Category e in Enum.GetValues(typeof(Product.Category))
                           select new
                           {
                               Category = e,
                           };
            ViewBag.EnumList = new SelectList(enumData, "Category", "Category");


            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Price,Diet,Supplier")] Product product)
        {
            
            if (ModelState.IsValid)
            {
                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // GET: Products/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Price,Diet,Supplier")] Product product)
        {
            if (id != product.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Product.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // GET: Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Product.FindAsync(id);
            _context.Product.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
            return _context.Product.Any(e => e.Id == id);
        }
    }
}
