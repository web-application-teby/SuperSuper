using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SuperSuper.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;



namespace SuperSuper.Controllers
{
    public class CustomersController : Controller
    {
        private readonly SuperSuperContext _context;

        Customer customer = new Customer
        {
            UserName = "customer",
            Address = "Israel",
            EmailAddress = "Yarden@gmail.com",
            Password = "customer",
            confirmPassword = "customer"
        };
        
        public CustomersController(SuperSuperContext context)
        {
            _context = context;

            try
            {
                var ctm = _context.Customer.Single(u => u.UserName == customer.UserName);
            }
            catch
            {
                _context.Add(customer);
                _context.SaveChanges();
            }
            
        }


        // GET: Customers
        public async Task<IActionResult> Index()
        {
            return View(await _context.Customer.ToListAsync());
        }


        // GET: Customers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customer
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // GET: Customers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Customers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserName,Address,EmailAdress,Password")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(customer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(customer);
        }

        // GET: Customers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customer.FindAsync(id);
            if (customer == null)
            {
                return NotFound();
            }
            return View(customer);
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UserName,Address,EmailAdress,Password")] Customer customer)
        {
            if (id != customer.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerExists(customer.Id))
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
            return View(customer);
        }

        // GET: Customers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customer
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // POST: Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customer = await _context.Customer.FindAsync(id);
            _context.Customer.Remove(customer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustomerExists(int id)
        {
            return _context.Customer.Any(e => e.Id == id);
        }


        //register (get)
        public ActionResult register()
        {
            return View();

        }

        //register (post)
        [HttpPost]
        public ActionResult register(Customer customer)
        {
            if (ModelState.IsValid)
            {
                _context.Customer.Add(customer);
                _context.SaveChanges();
            }

            //ModelState.Clear();
            //ViewBag.Message = "Welcome" + customer.UserName + " " + "(" + customer.Id + ")" + "!" +
            //"\n" + "we are glad you chose to be part of SuperSuper family";

            return RedirectToAction("login", customer);


        }

        //login (get)
        public ActionResult login()
        {
            return View();
        }


        //login (set)
        [HttpPost]
        public ActionResult login(Customer customer)
        {
            try
            {
                var ctm = _context.Customer.Single(u => (u.UserName.Equals(customer.UserName) && u.Password.Equals(customer.Password)));
                if (ctm != null)
                {

                    HttpContext.Session.Clear();
                    //save id to the session
                    HttpContext.Session.SetInt32("customerid", ctm.Id);

                    //save userName to the session
                    HttpContext.Session.SetString("userName", ctm.UserName.ToString());

                    return RedirectToAction("Index", "Products");
                }
            }
            catch (Exception error)
            {
                ModelState.AddModelError("", "userName or Password is wrong");
                return View();
            }

            return View();
        }

        public ActionResult loggedin()
        {
            if (HttpContext.Session.GetString("id") != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("login");
            }
        }

    }

}
