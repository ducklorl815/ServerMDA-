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
    public class 導演總表directorController : Controller
    {
        private readonly MDAContext _context;

        public 導演總表directorController(MDAContext context)
        {
            _context = context;
        }

        // GET: 導演總表director
        public async Task<IActionResult> Index()
        {
            return View(await _context.導演總表directors.ToListAsync());
        }

        // GET: 導演總表director/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var 導演總表director = await _context.導演總表directors
                .FirstOrDefaultAsync(m => m.導演編號directorId == id);
            if (導演總表director == null)
            {
                return NotFound();
            }

            return View(導演總表director);
        }

        // GET: 導演總表director/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: 導演總表director/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("導演編號directorId,中文名字nameCht,英文名字nameEng,導演照片image")] 導演總表director 導演總表director)
        {
            if (ModelState.IsValid)
            {
                _context.Add(導演總表director);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(導演總表director);
        }

        // GET: 導演總表director/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var 導演總表director = await _context.導演總表directors.FindAsync(id);
            if (導演總表director == null)
            {
                return NotFound();
            }
            return View(導演總表director);
        }

        // POST: 導演總表director/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("導演編號directorId,中文名字nameCht,英文名字nameEng,導演照片image")] 導演總表director 導演總表director)
        {
            if (id != 導演總表director.導演編號directorId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(導演總表director);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!導演總表directorExists(導演總表director.導演編號directorId))
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
            return View(導演總表director);
        }

        // GET: 導演總表director/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var 導演總表director = await _context.導演總表directors
                .FirstOrDefaultAsync(m => m.導演編號directorId == id);
            if (導演總表director == null)
            {
                return NotFound();
            }

            return View(導演總表director);
        }

        // POST: 導演總表director/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var 導演總表director = await _context.導演總表directors.FindAsync(id);
            _context.導演總表directors.Remove(導演總表director);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool 導演總表directorExists(int id)
        {
            return _context.導演總表directors.Any(e => e.導演編號directorId == id);
        }
        public FileResult ShowPhoto(int id)
        {
            導演總表director director = _context.導演總表directors.Find(id);
            byte[] context = director.導演照片image;
            return File(context, "image/jpeg");
        }
    }
}
