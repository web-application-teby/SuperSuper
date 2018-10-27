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
            Name = "Milk",
            Fat = false,
            Kosher = true,
            Price = 5.90,
            Supplier = "Shupersal"
        };

        Product p2 = new Product
        {
            Name = "Milk",
            Fat = false,
            Kosher = true,
            Price = 6.10,
            Supplier = "Super Yehuda"
        };

        Product p3 = new Product
        {
            Name = "Milk",
            Fat = false,
            Kosher = true,
            Price = 6.30,
            Supplier = "Tiv Taam"
        };

        Product p4 = new Product
        {
            Name = "Bread",
            Fat = false,
            Kosher = true,
            Price = 25.90,
            Supplier = "Shupersal"
        };

        Product p5 = new Product
        {
            Name = "Bread",
            Fat = false,
            Kosher = true,
            Price = 16.10,
            Supplier = "Super Yehuda"
        };

        Product p6 = new Product
        {
            Name = "Bread",
            Fat = false,
            Kosher = true,
            Price = 16.30,
            Supplier = "Tiv Taam"
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

            return View("Details", product);
        }

        // Post: Products search
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(Product.Category category, bool fat, string productName)
        {
            //var result = from t in _context.Product select t;

            var result = from row in _context.Product
                         group row by row.Name into grp
                         select grp.OrderBy(a => a.Price).First();

            if (!string.IsNullOrEmpty(productName))
            {
                result = result.Where(x => x.Name.Contains(productName));
            }

            if (fat == true)
            {
                result = result.Where(x => x.Fat == true);
            }

            return View(await result.ToListAsync());
        }

        
        // GET: Products
        public async Task<IActionResult> Index()
        {
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
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Price,Fat,Supplier")] Product product)
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
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Price,Fat,Supplier")] Product product)
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
