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
    public class Stock_MasterController : Controller
    {
        private readonly New_Stock_ManagementContext _context;

        public Stock_MasterController(New_Stock_ManagementContext context)
        {
            _context = context;
        }

        // GET: Stock_Master
        public async Task<IActionResult> Index()
        {
            return View(await _context.Stock_Master.ToListAsync());
        }

        // GET: Stock_Master/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stock_Master = await _context.Stock_Master
                .FirstOrDefaultAsync(m => m.Stock_ID == id);
            if (stock_Master == null)
            {
                return NotFound();
            }

            return View(stock_Master);
        }

        // GET: Stock_Master/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Stock_Master/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Stock_ID,Company_Name,Item_Name,Type,Total_Qty,Available_Qty,Sell_Qty,Available_Price,sell_price")] Stock_Master stock_Master)
        {
            if (ModelState.IsValid)
            {
                _context.Add(stock_Master);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(stock_Master);
        }

        // GET: Stock_Master/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stock_Master = await _context.Stock_Master.FindAsync(id);
            if (stock_Master == null)
            {
                return NotFound();
            }
            return View(stock_Master);
        }

        // POST: Stock_Master/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Stock_ID,Company_Name,Item_Name,Type,Total_Qty,Available_Qty,Sell_Qty,Available_Price,sell_price")] Stock_Master stock_Master)
        {
            if (id != stock_Master.Stock_ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(stock_Master);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Stock_MasterExists(stock_Master.Stock_ID))
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
            return View(stock_Master);
        }

        // GET: Stock_Master/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stock_Master = await _context.Stock_Master
                .FirstOrDefaultAsync(m => m.Stock_ID == id);
            if (stock_Master == null)
            {
                return NotFound();
            }

            return View(stock_Master);
        }

        // POST: Stock_Master/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var stock_Master = await _context.Stock_Master.FindAsync(id);
            _context.Stock_Master.Remove(stock_Master);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Stock_MasterExists(int id)
        {
            return _context.Stock_Master.Any(e => e.Stock_ID == id);
        }
    }
}
