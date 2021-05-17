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
    public class Payment_MasterController : Controller
    {
        private readonly New_Stock_ManagementContext _context;

        public Payment_MasterController(New_Stock_ManagementContext context)
        {
            _context = context;
        }

        // GET: Payment_Master
        public async Task<IActionResult> Index()
        {
            return View(await _context.Payment_Master.ToListAsync());
        }

        // GET: Payment_Master/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var payment_Master = await _context.Payment_Master
                .FirstOrDefaultAsync(m => m.Payment_ID == id);
            if (payment_Master == null)
            {
                return NotFound();
            }

            return View(payment_Master);
        }

        // GET: Payment_Master/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Payment_Master/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Payment_ID,Party_Name,Mobile,Qty,Amount,Paid_Amt,Status,Payment_Edate")] Payment_Master payment_Master)
        {
            if (ModelState.IsValid)
            {
                _context.Add(payment_Master);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(payment_Master);
        }

        // GET: Payment_Master/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var payment_Master = await _context.Payment_Master.FindAsync(id);
            if (payment_Master == null)
            {
                return NotFound();
            }
            return View(payment_Master);
        }

        // POST: Payment_Master/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Payment_ID,Party_Name,Mobile,Qty,Amount,Paid_Amt,Status,Payment_Edate")] Payment_Master payment_Master)
        {
            if (id != payment_Master.Payment_ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(payment_Master);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Payment_MasterExists(payment_Master.Payment_ID))
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
            return View(payment_Master);
        }

        // GET: Payment_Master/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var payment_Master = await _context.Payment_Master
                .FirstOrDefaultAsync(m => m.Payment_ID == id);
            if (payment_Master == null)
            {
                return NotFound();
            }

            return View(payment_Master);
        }

        // POST: Payment_Master/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var payment_Master = await _context.Payment_Master.FindAsync(id);
            _context.Payment_Master.Remove(payment_Master);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Payment_MasterExists(int id)
        {
            return _context.Payment_Master.Any(e => e.Payment_ID == id);
        }
    }
}
