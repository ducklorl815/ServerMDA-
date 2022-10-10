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
    public class 影城mainTheaterController : Controller
    {
        private readonly MDAContext _context;

        public 影城mainTheaterController(MDAContext context)
        {
            _context = context;
        }

        // GET: 影城mainTheater
        public async Task<IActionResult> Index()
        {
            return View(await _context.影城mainTheaters.ToListAsync());
        }

        // GET: 影城mainTheater/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var 影城mainTheater = await _context.影城mainTheaters
                .FirstOrDefaultAsync(m => m.影城編號mainTheaterId == id);
            if (影城mainTheater == null)
            {
                return NotFound();
            }

            return View(影城mainTheater);
        }

        // GET: 影城mainTheater/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: 影城mainTheater/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("影城編號mainTheaterId,影城名稱mainTheaterName")] 影城mainTheater 影城mainTheater)
        {
            if (ModelState.IsValid)
            {
                _context.Add(影城mainTheater);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(影城mainTheater);
        }

        // GET: 影城mainTheater/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var 影城mainTheater = await _context.影城mainTheaters.FindAsync(id);
            if (影城mainTheater == null)
            {
                return NotFound();
            }
            return View(影城mainTheater);
        }

        // POST: 影城mainTheater/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("影城編號mainTheaterId,影城名稱mainTheaterName")] 影城mainTheater 影城mainTheater)
        {
            if (id != 影城mainTheater.影城編號mainTheaterId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(影城mainTheater);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!影城mainTheaterExists(影城mainTheater.影城編號mainTheaterId))
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
            return View(影城mainTheater);
        }

        // GET: 影城mainTheater/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var 影城mainTheater = await _context.影城mainTheaters
                .FirstOrDefaultAsync(m => m.影城編號mainTheaterId == id);
            if (影城mainTheater == null)
            {
                return NotFound();
            }

            return View(影城mainTheater);
        }

        // POST: 影城mainTheater/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var 影城mainTheater = await _context.影城mainTheaters.FindAsync(id);
            _context.影城mainTheaters.Remove(影城mainTheater);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool 影城mainTheaterExists(int id)
        {
            return _context.影城mainTheaters.Any(e => e.影城編號mainTheaterId == id);
        }
    }
}
