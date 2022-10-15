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
    public class 演員總表actorController : Controller
    {
        private readonly MDAContext _context;

        public 演員總表actorController(MDAContext context)
        {
            _context = context;
        }

        // GET: 演員總表actor
        public async Task<IActionResult> Index()
        {
            return View(await _context.演員總表actors.ToListAsync());
        }

        // GET: 演員總表actor/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var 演員總表actor = await _context.演員總表actors
                .FirstOrDefaultAsync(m => m.演員編號actorsId == id);
            if (演員總表actor == null)
            {
                return NotFound();
            }

            return View(演員總表actor);
        }

        // GET: 演員總表actor/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: 演員總表actor/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("演員編號actorsId,中文名字nameCht,英文名字nameEng,演員照片image")] 演員總表actor 演員總表actor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(演員總表actor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(演員總表actor);
        }

        // GET: 演員總表actor/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var 演員總表actor = await _context.演員總表actors.FindAsync(id);
            if (演員總表actor == null)
            {
                return NotFound();
            }
            return View(演員總表actor);
        }

        // POST: 演員總表actor/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("演員編號actorsId,中文名字nameCht,英文名字nameEng,演員照片image")] 演員總表actor 演員總表actor)
        {
            if (id != 演員總表actor.演員編號actorsId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(演員總表actor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!演員總表actorExists(演員總表actor.演員編號actorsId))
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
            return View(演員總表actor);
        }

        // GET: 演員總表actor/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var 演員總表actor = await _context.演員總表actors
                .FirstOrDefaultAsync(m => m.演員編號actorsId == id);
            if (演員總表actor == null)
            {
                return NotFound();
            }

            return View(演員總表actor);
        }

        // POST: 演員總表actor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var 演員總表actor = await _context.演員總表actors.FindAsync(id);
            _context.演員總表actors.Remove(演員總表actor);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool 演員總表actorExists(int id)
        {
            return _context.演員總表actors.Any(e => e.演員編號actorsId == id);
        }
    }
}
