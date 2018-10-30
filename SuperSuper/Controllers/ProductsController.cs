using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SuperSuper.Models;

namespace SuperSuper.Controllers
{
    public class ProductsController : Controller
    {
        private readonly SuperSuperContext _context;

        Product p1 = new Product
        {
            Name = "Milk 3% Tnuva",
            Diet = false,
            Kosher = true,
            Price = 5.80,
            Supplier = "Shupersal",
            category = Product.Category.Dairy
        };

        Product p7 = new Product
        {
            Name = "Milk 1% Tnuva",
            Diet = true,
            Kosher = true,
            Price = 5.90,
            Supplier = "Shupersal",
            category = Product.Category.Dairy
        };

        Product p8 = new Product
        {
            Name = "Bamba Osem",
            Diet = true,
            Kosher = true,
            Price = 3.50,
            Supplier = "Tiv Taam",
            category = Product.Category.Snacks
        };

        Product p2 = new Product
        {
            Name = "Milk 2% Tnuva",
            Diet = false,
            Kosher = true,
            Price = 6.10,
            Supplier = "Super Yehuda",
            category = Product.Category.Dairy
        };

        Product p3 = new Product
        {
            Name = "Milk 2% Tnuva",
            Diet = false,
            Kosher = true,
            Price = 6.30,
            Supplier = "Tiv Taam",
            category = Product.Category.Dairy
        };

        Product p4 = new Product
        {
            Name = "Bread",
            Diet = false,
            Kosher = true,
            Price = 25.90,
            Supplier = "Shupersal",
            category = Product.Category.Cupboard
        };

        Product p5 = new Product
        {
            Name = "Bread",
            Diet = false,
            Kosher = true,
            Price = 16.10,
            Supplier = "Super Yehuda",
            category = Product.Category.Cupboard
        };

        Product p6 = new Product
        {
            Name = "Bread",
            Diet = false,
            Kosher = true,
            Price = 16.30,
            Supplier = "Tiv Taam",
            category = Product.Category.Cupboard
        };

        Product p9 = new Product
        {
            Name = "Bamba Osem",
            Diet = false,
            Kosher = true,
            Price = 6.30,
            Supplier = "Tiv Taam",
            category = Product.Category.Snacks
        };

        public ProductsController(SuperSuperContext context)
        {
            _context = context;
            _context.Add(p1);
            _context.Add(p2);
            _context.Add(p3);
            _context.Add(p4);
            _context.Add(p5);
            _context.Add(p6);
            _context.Add(p7);
            _context.Add(p8);
            _context.Add(p9);
            _context.SaveChanges();
        }


        public async Task<IActionResult> Add(int? id)
        {
            Customer c = new Customer
            {
                UserName = "aa"
            };
            _context.Add(c);
            _context.SaveChanges();

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
                Customer = c,
                PurchesDate = DateTime.Now,
                Purchesed = false
            };

            _context.Purcheses.Add(p);
            _context.SaveChanges();

            TempData["Message"] = "Product " + product.Name + " was added to your basket";
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

            return View(result);
            //return View(await _context.Product.ToListAsync());
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
                    _context.Update(product);
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
