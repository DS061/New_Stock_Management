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
    public class Stock_in_MasterController : Controller
    {
        private readonly New_Stock_ManagementContext _context;

        public Stock_in_MasterController(New_Stock_ManagementContext context)
        {
            _context = context;
        }

        // GET: Stock_in_Master
        public async Task<IActionResult> Index()
        {
            return View(await _context.Stock_in_Master.ToListAsync());
        }

        // GET: Stock_in_Master/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stock_in_Master = await _context.Stock_in_Master
                .FirstOrDefaultAsync(m => m.Stock_ID == id);
            if (stock_in_Master == null)
            {
                return NotFound();
            }

            return View(stock_in_Master);
        }

        // GET: Stock_in_Master/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Stock_in_Master/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Stock_ID,Company_Name,Item_Name,Type,Qty,Buy_Price,Sell_Price,Location,Stock_Edate")] Stock_in_Master stock_in_Master)
        {
            if (ModelState.IsValid)
            {
                _context.Add(stock_in_Master);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(stock_in_Master);
        }

        // GET: Stock_in_Master/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stock_in_Master = await _context.Stock_in_Master.FindAsync(id);
            if (stock_in_Master == null)
            {
                return NotFound();
            }
            return View(stock_in_Master);
        }

        // POST: Stock_in_Master/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Stock_ID,Company_Name,Item_Name,Type,Qty,Buy_Price,Sell_Price,Location,Stock_Edate")] Stock_in_Master stock_in_Master)
        {
            if (id != stock_in_Master.Stock_ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(stock_in_Master);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Stock_in_MasterExists(stock_in_Master.Stock_ID))
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
            return View(stock_in_Master);
        }

        // GET: Stock_in_Master/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stock_in_Master = await _context.Stock_in_Master
                .FirstOrDefaultAsync(m => m.Stock_ID == id);
            if (stock_in_Master == null)
            {
                return NotFound();
            }

            return View(stock_in_Master);
        }

        // POST: Stock_in_Master/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var stock_in_Master = await _context.Stock_in_Master.FindAsync(id);
            _context.Stock_in_Master.Remove(stock_in_Master);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Stock_in_MasterExists(int id)
        {
            return _context.Stock_in_Master.Any(e => e.Stock_ID == id);
        }
    }
}
