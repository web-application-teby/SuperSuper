using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SuperSuper.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;

namespace SuperSuper.Controllers
{
    public class AdminsController : Controller
    {
        private readonly SuperSuperContext _context;

        public AdminsController(SuperSuperContext context)
        {
            _context = context;
            Admin admin = new Admin()
            {
                Name = "admin",
                Password = "admin"
            };


            try
            {
                var ctm = _context.Admin.Single(u => u.Name == admin.Name);
            }
            catch
            {
                _context.Add(admin);
                _context.SaveChanges();
            }
        }

        // GET: Admins
        public async Task<IActionResult> Index()
        {
            List<ProductPurchesedCount> result = new List<ProductPurchesedCount>();

            result =
                (from c in _context.Product
                 join o in _context.Purcheses
                 on c.Id equals o.ProductId
                 group c by c.Name into g
                 let ProductsCount = g.Count()
                 select new ProductPurchesedCount
                 {

                     productName = g.Key,
                     Count = ProductsCount
                 }).ToList();

            ViewBag.DataPoints = JsonConvert.SerializeObject(result.ToList());

            List<SupplierCount> supplierCount = new List<SupplierCount>();

            supplierCount =
                (from c in _context.Product
                 join o in _context.Purcheses
                 on c.Id equals o.ProductId
                 group c by c.Supplier into g
                 let ProductsCount = g.Count()
                 select new SupplierCount
                 {
                     Supplier = g.Key,
                     Count = ProductsCount
                 }).ToList();

            ViewBag.DataPoints2 = JsonConvert.SerializeObject(supplierCount.ToList());

            return View();
        }

        // GET: Admins/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var admin = await _context.Admin
                .FirstOrDefaultAsync(m => m.Id == id);
            if (admin == null)
            {
                return NotFound();
            }

            return View(admin);
        }

        // GET: Admins/CreateProduct
        public IActionResult CreateProduct()
        {
            return RedirectToAction("Create","Products");
        }

        // GET: Admins/EditProduct
        public IActionResult EditProduct()
        {
            return RedirectToAction("Index", "Products");
        }

        // POST: Admins/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Password")] Admin admin)
        {
            if (ModelState.IsValid)
            {
                _context.Add(admin);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(admin);
        }

        // GET: Admins/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var admin = await _context.Admin.FindAsync(id);
            if (admin == null)
            {
                return NotFound();
            }
            return View(admin);
        }

        // POST: Admins/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Password")] Admin admin)
        {
            if (id != admin.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(admin);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdminExists(admin.Id))
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
            return View(admin);
        }

        // GET: Admins/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var admin = await _context.Admin
                .FirstOrDefaultAsync(m => m.Id == id);
            if (admin == null)
            {
                return NotFound();
            }

            return View(admin);
        }

        // POST: Admins/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var admin = await _context.Admin.FindAsync(id);
            _context.Admin.Remove(admin);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AdminExists(int id)
        {
            return _context.Admin.Any(e => e.Id == id);
        }

        //login (get)
        public ActionResult adminLogin()
        {
            return View();
        }

        //login (set)
        [HttpPost]
        public ActionResult AdminLogin(Admin admin)
        {
            try
            {
                var ctm = _context.Admin.Single(u => (u.Name.Equals(admin.Name) && u.Password.Equals(admin.Password)));
                if (ctm != null)
                {
                    HttpContext.Session.Clear();
                    //save id to the session
                    HttpContext.Session.SetInt32("id", ctm.Id);
                    //save userName to the session
                    HttpContext.Session.SetString("Name", ctm.Name.ToString());

                    return RedirectToAction("Index", "Admins");
                }

            }
            catch (Exception error)
            {
                ModelState.AddModelError("", "Name or Password is wrong");
                return View();
            }

            return RedirectToAction("Index", "Admins");

        }
    }
}



