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
    public class CourierReceiversController : Controller
    {
        private readonly NewZealand_CourierContext _context;

        public CourierReceiversController(NewZealand_CourierContext context)
        {
            _context = context;
        }

        // GET: CourierReceivers
        public async Task<IActionResult> Index()
        {
            return View(await _context.CourierReceiver.ToListAsync());
        }

        // GET: CourierReceivers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courierReceiver = await _context.CourierReceiver
                .FirstOrDefaultAsync(m => m.Id == id);
            if (courierReceiver == null)
            {
                return NotFound();
            }

            return View(courierReceiver);
        }

        // GET: CourierReceivers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CourierReceivers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Receiver_Name,Receiver_Address,Receiver_Contact,Barcode")] CourierReceiver courierReceiver)
        {
            if (ModelState.IsValid)
            {
                _context.Add(courierReceiver);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(courierReceiver);
        }

        // GET: CourierReceivers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courierReceiver = await _context.CourierReceiver.FindAsync(id);
            if (courierReceiver == null)
            {
                return NotFound();
            }
            return View(courierReceiver);
        }

        // POST: CourierReceivers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Receiver_Name,Receiver_Address,Receiver_Contact,Barcode")] CourierReceiver courierReceiver)
        {
            if (id != courierReceiver.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(courierReceiver);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CourierReceiverExists(courierReceiver.Id))
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
            return View(courierReceiver);
        }

        // GET: CourierReceivers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courierReceiver = await _context.CourierReceiver
                .FirstOrDefaultAsync(m => m.Id == id);
            if (courierReceiver == null)
            {
                return NotFound();
            }

            return View(courierReceiver);
        }

        // POST: CourierReceivers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var courierReceiver = await _context.CourierReceiver.FindAsync(id);
            _context.CourierReceiver.Remove(courierReceiver);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CourierReceiverExists(int id)
        {
            return _context.CourierReceiver.Any(e => e.Id == id);
        }
    }
}
