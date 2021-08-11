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
    public class CourierOfficesController : Controller
    {
        private readonly NewZealand_CourierContext _context;

        public CourierOfficesController(NewZealand_CourierContext context)
        {
            _context = context;
        }

        // GET: CourierOffices
        public async Task<IActionResult> Index()
        {
            return View(await _context.CourierOffice.ToListAsync());
        }

        // GET: CourierOffices/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courierOffice = await _context.CourierOffice
                .FirstOrDefaultAsync(m => m.Id == id);
            if (courierOffice == null)
            {
                return NotFound();
            }

            return View(courierOffice);
        }

        // GET: CourierOffices/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CourierOffices/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Office_Name,Contact_Number,Location")] CourierOffice courierOffice)
        {
            if (ModelState.IsValid)
            {
                _context.Add(courierOffice);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(courierOffice);
        }

        // GET: CourierOffices/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courierOffice = await _context.CourierOffice.FindAsync(id);
            if (courierOffice == null)
            {
                return NotFound();
            }
            return View(courierOffice);
        }

        // POST: CourierOffices/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Office_Name,Contact_Number,Location")] CourierOffice courierOffice)
        {
            if (id != courierOffice.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(courierOffice);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CourierOfficeExists(courierOffice.Id))
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
            return View(courierOffice);
        }

        // GET: CourierOffices/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courierOffice = await _context.CourierOffice
                .FirstOrDefaultAsync(m => m.Id == id);
            if (courierOffice == null)
            {
                return NotFound();
            }

            return View(courierOffice);
        }

        // POST: CourierOffices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var courierOffice = await _context.CourierOffice.FindAsync(id);
            _context.CourierOffice.Remove(courierOffice);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CourierOfficeExists(int id)
        {
            return _context.CourierOffice.Any(e => e.Id == id);
        }
    }
}
