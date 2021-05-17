using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using New_Stock_Management.Data;
using New_Stock_Management.Models;

namespace New_Stock_Management.Controllers
{
    public class Bill_Payment_MasterController : Controller
    {
        private readonly New_Stock_ManagementContext _context;

        public Bill_Payment_MasterController(New_Stock_ManagementContext context)
        {
            _context = context;
        }

        // GET: Bill_Payment_Master
        public async Task<IActionResult> Index()
        {
            return View(await _context.Bill_Payment_Master.ToListAsync());
        }

        // GET: Bill_Payment_Master/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bill_Payment_Master = await _context.Bill_Payment_Master
                .FirstOrDefaultAsync(m => m.Bill_ID == id);
            if (bill_Payment_Master == null)
            {
                return NotFound();
            }

            return View(bill_Payment_Master);
        }

        // GET: Bill_Payment_Master/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Bill_Payment_Master/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Bill_ID,Company_Name,Amount,type,Payment_Date")] Bill_Payment_Master bill_Payment_Master)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bill_Payment_Master);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bill_Payment_Master);
        }

        // GET: Bill_Payment_Master/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bill_Payment_Master = await _context.Bill_Payment_Master.FindAsync(id);
            if (bill_Payment_Master == null)
            {
                return NotFound();
            }
            return View(bill_Payment_Master);
        }

        // POST: Bill_Payment_Master/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Bill_ID,Company_Name,Amount,type,Payment_Date")] Bill_Payment_Master bill_Payment_Master)
        {
            if (id != bill_Payment_Master.Bill_ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bill_Payment_Master);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Bill_Payment_MasterExists(bill_Payment_Master.Bill_ID))
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
            return View(bill_Payment_Master);
        }

        // GET: Bill_Payment_Master/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bill_Payment_Master = await _context.Bill_Payment_Master
                .FirstOrDefaultAsync(m => m.Bill_ID == id);
            if (bill_Payment_Master == null)
            {
                return NotFound();
            }

            return View(bill_Payment_Master);
        }

        // POST: Bill_Payment_Master/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bill_Payment_Master = await _context.Bill_Payment_Master.FindAsync(id);
            _context.Bill_Payment_Master.Remove(bill_Payment_Master);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Bill_Payment_MasterExists(int id)
        {
            return _context.Bill_Payment_Master.Any(e => e.Bill_ID == id);
        }
    }
}
