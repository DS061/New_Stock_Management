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
    public class Company_MasterController : Controller
    {
        private readonly New_Stock_ManagementContext _context;

        public Company_MasterController(New_Stock_ManagementContext context)
        {
            _context = context;
        }

        // GET: Company_Master
        public async Task<IActionResult> Index()
        {
            return View(await _context.Company_Master.ToListAsync());
        }

        // GET: Company_Master/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var company_Master = await _context.Company_Master
                .FirstOrDefaultAsync(m => m.Company_ID == id);
            if (company_Master == null)
            {
                return NotFound();
            }

            return View(company_Master);
        }

        // GET: Company_Master/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Company_Master/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Company_ID,Company_Name,Contact_Number,Company_Address,Contact,Company_Edate")] Company_Master company_Master)
        {
            if (ModelState.IsValid)
            {
                _context.Add(company_Master);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(company_Master);
        }

        // GET: Company_Master/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var company_Master = await _context.Company_Master.FindAsync(id);
            if (company_Master == null)
            {
                return NotFound();
            }
            return View(company_Master);
        }

        // POST: Company_Master/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Company_ID,Company_Name,Contact_Number,Company_Address,Contact,Company_Edate")] Company_Master company_Master)
        {
            if (id != company_Master.Company_ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(company_Master);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Company_MasterExists(company_Master.Company_ID))
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
            return View(company_Master);
        }

        // GET: Company_Master/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var company_Master = await _context.Company_Master
                .FirstOrDefaultAsync(m => m.Company_ID == id);
            if (company_Master == null)
            {
                return NotFound();
            }

            return View(company_Master);
        }

        // POST: Company_Master/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var company_Master = await _context.Company_Master.FindAsync(id);
            _context.Company_Master.Remove(company_Master);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Company_MasterExists(int id)
        {
            return _context.Company_Master.Any(e => e.Company_ID == id);
        }
    }
}
