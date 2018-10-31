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
    public class PurchesesController : Controller
    {
        private readonly SuperSuperContext _context;


        int t = 0; 

        
        public PurchesesController(SuperSuperContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Buy()
        {

            int customerId = 2; //workaround till we will have customer ID

            var model = _context.Purcheses.Where(x => customerId.Equals(x.CustomerId)).ToList();
            model.ForEach(a => a.Purchesed = true);

            _context.SaveChanges();
            return RedirectToAction(nameof(Index));

        }
            // GET: Purcheses
            public async Task<IActionResult> Index()
        {
            IEnumerable<PurchesesView> model = null;

            model = (from c in _context.Purcheses
                     join u in _context.Product 
                     on c.ProductId equals u.Id
                     //where (c.CustomerId == 1 && !c.Purchesed) - this line will filter the secific customer bucket
                     select new PurchesesView
                     {
                         PurchesDate = c.PurchesDate,
                         Purchesed = c.Purchesed,
                         ProductId = c.ProductId,
                         CustomerId = c.CustomerId,
                         ProductName = u.Name
                     }
                     );

            _context.SaveChanges();

            //IEnumerable<CustomerBasket> customerBasket = null;

            //customerBasket = from row in _context.PurchesesView
            //                 group row by row.ProductName into grp
            //                 select new CustomerBasket
            //                 {
            //                     ProductName = grp.Key,
            //                     ProductsCount = grp.Count()
            //                 };


            //return View("CustomerBasket", customerBasket);
            return View("PurchesesView", model);
        }

        // GET: Purcheses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var purcheses = await _context.Purcheses
                .FirstOrDefaultAsync(m => m.Id == id);
            if (purcheses == null)
            {
                return NotFound();
            }

            return View("Purcheses", id);
        }

        // GET: Purcheses/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Purcheses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,PurchesDate")] Purcheses purcheses)
        {
            if (ModelState.IsValid)
            {
                _context.Add(purcheses);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(purcheses);
        }

        // GET: Purcheses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var purcheses = await _context.Purcheses.FindAsync(id);
            if (purcheses == null)
            {
                return NotFound();
            }
            return View(purcheses);
        }

        // POST: Purcheses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,PurchesDate")] Purcheses purcheses)
        {
            if (id != purcheses.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(purcheses);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PurchesesExists(purcheses.Id))
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
            return View(purcheses);
        }

        // GET: Purcheses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var purcheses = await _context.Purcheses
                .FirstOrDefaultAsync(m => m.Id == id);
            if (purcheses == null)
            {
                return NotFound();
            }

            return View(purcheses);
        }

        // POST: Purcheses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var purcheses = await _context.Purcheses.FindAsync(id);
            _context.Purcheses.Remove(purcheses);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PurchesesExists(int id)
        {
            return _context.Purcheses.Any(e => e.Id == id);
        }
    }
}
