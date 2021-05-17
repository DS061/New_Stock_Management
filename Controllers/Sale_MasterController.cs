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
    public class Sale_MasterController : Controller
    {
        private readonly New_Stock_ManagementContext _context;

        public Sale_MasterController(New_Stock_ManagementContext context)
        {
            _context = context;
        }

        // GET: Sale_Master
        public async Task<IActionResult> Index()
        {
            return View(await _context.Sale_Master.ToListAsync());
        }

        // GET: Sale_Master/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sale_Master = await _context.Sale_Master
                .FirstOrDefaultAsync(m => m.Sale_ID == id);
            if (sale_Master == null)
            {
                return NotFound();
            }

            return View(sale_Master);
        }

        // GET: Sale_Master/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Sale_Master/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Sale_ID,Party_Name,Mobile,Company,Item_Name,Type,Qty,Price,Total_Price,Bill_No,Stock_Edate")] Sale_Master sale_Master)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sale_Master);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sale_Master);
        }

        // GET: Sale_Master/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sale_Master = await _context.Sale_Master.FindAsync(id);
            if (sale_Master == null)
            {
                return NotFound();
            }
            return View(sale_Master);
        }

        // POST: Sale_Master/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Sale_ID,Party_Name,Mobile,Company,Item_Name,Type,Qty,Price,Total_Price,Bill_No,Stock_Edate")] Sale_Master sale_Master)
        {
            if (id != sale_Master.Sale_ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sale_Master);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Sale_MasterExists(sale_Master.Sale_ID))
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
            return View(sale_Master);
        }

        // GET: Sale_Master/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sale_Master = await _context.Sale_Master
                .FirstOrDefaultAsync(m => m.Sale_ID == id);
            if (sale_Master == null)
            {
                return NotFound();
            }

            return View(sale_Master);
        }

        // POST: Sale_Master/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sale_Master = await _context.Sale_Master.FindAsync(id);
            _context.Sale_Master.Remove(sale_Master);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Sale_MasterExists(int id)
        {
            return _context.Sale_Master.Any(e => e.Sale_ID == id);
        }
    }
}
