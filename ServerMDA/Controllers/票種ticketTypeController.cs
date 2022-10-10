using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ServerMDA.Models;

namespace ServerMDA.Controllers
{
    public class 票種ticketTypeController : Controller
    {
        private readonly MDAContext _context;

        public 票種ticketTypeController(MDAContext context)
        {
            _context = context;
        }

        // GET: 票種ticketType
        public async Task<IActionResult> Index()
        {
            return View(await _context.票種ticketTypes.ToListAsync());
        }

        // GET: 票種ticketType/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var 票種ticketType = await _context.票種ticketTypes
                .FirstOrDefaultAsync(m => m.票種編號ticketTypeId == id);
            if (票種ticketType == null)
            {
                return NotFound();
            }

            return View(票種ticketType);
        }

        // GET: 票種ticketType/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: 票種ticketType/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("票種編號ticketTypeId,票種名稱ticketTypeName")] 票種ticketType 票種ticketType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(票種ticketType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(票種ticketType);
        }

        // GET: 票種ticketType/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var 票種ticketType = await _context.票種ticketTypes.FindAsync(id);
            if (票種ticketType == null)
            {
                return NotFound();
            }
            return View(票種ticketType);
        }

        // POST: 票種ticketType/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("票種編號ticketTypeId,票種名稱ticketTypeName")] 票種ticketType 票種ticketType)
        {
            if (id != 票種ticketType.票種編號ticketTypeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(票種ticketType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!票種ticketTypeExists(票種ticketType.票種編號ticketTypeId))
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
            return View(票種ticketType);
        }

        // GET: 票種ticketType/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var 票種ticketType = await _context.票種ticketTypes
                .FirstOrDefaultAsync(m => m.票種編號ticketTypeId == id);
            if (票種ticketType == null)
            {
                return NotFound();
            }

            return View(票種ticketType);
        }

        // POST: 票種ticketType/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var 票種ticketType = await _context.票種ticketTypes.FindAsync(id);
            _context.票種ticketTypes.Remove(票種ticketType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool 票種ticketTypeExists(int id)
        {
            return _context.票種ticketTypes.Any(e => e.票種編號ticketTypeId == id);
        }
    }
}
