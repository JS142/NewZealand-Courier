using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NewZealand_Courier.Data;
using NewZealand_Courier.Models;

namespace NewZealand_Courier.Controllers
{
    [Authorize]
    public class CourierDeliversController : Controller
    {
        
        private readonly NewZealand_CourierContext _context;

        public CourierDeliversController(NewZealand_CourierContext context)
        {
            _context = context;
        }

        // GET: CourierDelivers
        public async Task<IActionResult> Index()
        {
            return View(await _context.CourierDeliver.ToListAsync());
        }

        // GET: CourierDelivers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courierDeliver = await _context.CourierDeliver
                .FirstOrDefaultAsync(m => m.Id == id);
            if (courierDeliver == null)
            {
                return NotFound();
            }

            return View(courierDeliver);
        }

        // GET: CourierDelivers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CourierDelivers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DeliveryPerson_Name,DeliveryPerson_Address,DeliveryPerson_Contact,DeliveryPerson_EmailId")] CourierDeliver courierDeliver)
        {
            if (ModelState.IsValid)
            {
                _context.Add(courierDeliver);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(courierDeliver);
        }

        // GET: CourierDelivers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courierDeliver = await _context.CourierDeliver.FindAsync(id);
            if (courierDeliver == null)
            {
                return NotFound();
            }
            return View(courierDeliver);
        }

        // POST: CourierDelivers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DeliveryPerson_Name,DeliveryPerson_Address,DeliveryPerson_Contact,DeliveryPerson_EmailId")] CourierDeliver courierDeliver)
        {
            if (id != courierDeliver.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(courierDeliver);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CourierDeliverExists(courierDeliver.Id))
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
            return View(courierDeliver);
        }

        // GET: CourierDelivers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courierDeliver = await _context.CourierDeliver
                .FirstOrDefaultAsync(m => m.Id == id);
            if (courierDeliver == null)
            {
                return NotFound();
            }

            return View(courierDeliver);
        }

        // POST: CourierDelivers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var courierDeliver = await _context.CourierDeliver.FindAsync(id);
            _context.CourierDeliver.Remove(courierDeliver);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CourierDeliverExists(int id)
        {
            return _context.CourierDeliver.Any(e => e.Id == id);
        }
    }
}
