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
    public class Client_MasterController : Controller
    {
        private readonly New_Stock_ManagementContext _context;

        public Client_MasterController(New_Stock_ManagementContext context)
        {
            _context = context;
        }

        // GET: Client_Master
        public async Task<IActionResult> Index()
        {
            return View(await _context.Client_Master.ToListAsync());
        }

        // GET: Client_Master/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var client_Master = await _context.Client_Master
                .FirstOrDefaultAsync(m => m.Client_ID == id);
            if (client_Master == null)
            {
                return NotFound();
            }

            return View(client_Master);
        }

        // GET: Client_Master/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Client_Master/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Client_ID,Client_Name,Client_Mobile,Client_Address,Client_Edate")] Client_Master client_Master)
        {
            if (ModelState.IsValid)
            {
                _context.Add(client_Master);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(client_Master);
        }

        // GET: Client_Master/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var client_Master = await _context.Client_Master.FindAsync(id);
            if (client_Master == null)
            {
                return NotFound();
            }
            return View(client_Master);
        }

        // POST: Client_Master/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Client_ID,Client_Name,Client_Mobile,Client_Address,Client_Edate")] Client_Master client_Master)
        {
            if (id != client_Master.Client_ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(client_Master);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Client_MasterExists(client_Master.Client_ID))
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
            return View(client_Master);
        }

        // GET: Client_Master/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var client_Master = await _context.Client_Master
                .FirstOrDefaultAsync(m => m.Client_ID == id);
            if (client_Master == null)
            {
                return NotFound();
            }

            return View(client_Master);
        }

        // POST: Client_Master/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var client_Master = await _context.Client_Master.FindAsync(id);
            _context.Client_Master.Remove(client_Master);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Client_MasterExists(int id)
        {
            return _context.Client_Master.Any(e => e.Client_ID == id);
        }
    }
}
