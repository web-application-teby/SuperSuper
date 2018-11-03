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

        public ProductsController(SuperSuperContext context)
        {
            _context = context;
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
