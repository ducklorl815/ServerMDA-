using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ServerMDA.Models;
using ServerMDA.ViewModel;

namespace ServerMDA.Controllers
{
    public class 電影movieController : Controller
    {
        private readonly MDAContext _context;

        public 電影movieController(MDAContext context)
        {
            _context = context;
        }

        // GET: 電影movie
        public async Task<IActionResult> Index()
        {


            var mDAContext = _context.電影movies.Include(電 => 電.系列編號series).Include(電 => 電.電影分級編號rating);
            return View(await mDAContext.ToListAsync());
        }

        // GET: 電影movie/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var 電影movie = await _context.電影movies
                .Include(電 => 電.系列編號series)
                .Include(電 => 電.電影分級編號rating)
                .FirstOrDefaultAsync(m => m.電影編號movieId == id);
            if (電影movie == null)
            {
                return NotFound();
            }

            return View(電影movie);
        }

        // GET: 電影movie/Create
        public IActionResult Create()
        {
            ViewData["系列編號seriesId"] = new SelectList(_context.系列電影movieSeries, "系列編號seriesId", "系列名稱seriesName");
            ViewData["電影分級編號ratingId"] = new SelectList(_context.電影分級movieRatings, "分級編號ratingId", "分級級數ratingLevel");
            return View();
        }

        // POST: 電影movie/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("電影編號movieId,系列編號seriesId,中文標題titleCht,英文標題titleEng,上映年份releaseYear,上映日期releaseDate,片長runtime,電影分級編號ratingId,評分rate,期待度anticipation,票房boxOffice,劇情大綱plot")] 電影movie 電影movie)
        {
            if (ModelState.IsValid)
            {
                _context.Add(電影movie);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["系列編號seriesId"] = new SelectList(_context.系列電影movieSeries, "系列編號seriesId", "系列名稱seriesName", 電影movie.系列編號seriesId);
            ViewData["電影分級編號ratingId"] = new SelectList(_context.電影分級movieRatings, "分級編號ratingId", "分級級數ratingLevel", 電影movie.電影分級編號ratingId);
            return View(電影movie);
        }

        // GET: 電影movie/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var 電影movie = await _context.電影movies.FindAsync(id);
            if (電影movie == null)
            {
                return NotFound();
            }
            ViewData["系列編號seriesId"] = new SelectList(_context.系列電影movieSeries, "系列編號seriesId", "系列名稱seriesName", 電影movie.系列編號seriesId);
            ViewData["電影分級編號ratingId"] = new SelectList(_context.電影分級movieRatings, "分級編號ratingId", "分級級數ratingLevel", 電影movie.電影分級編號ratingId);
            return View(電影movie);
        }

        // POST: 電影movie/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("電影編號movieId,系列編號seriesId,中文標題titleCht,英文標題titleEng,上映年份releaseYear,上映日期releaseDate,片長runtime,電影分級編號ratingId,評分rate,期待度anticipation,票房boxOffice,劇情大綱plot")] 電影movie 電影movie)
        {
            if (id != 電影movie.電影編號movieId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(電影movie);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!電影movieExists(電影movie.電影編號movieId))
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
            ViewData["系列編號seriesId"] = new SelectList(_context.系列電影movieSeries, "系列編號seriesId", "系列名稱seriesName", 電影movie.系列編號seriesId);
            ViewData["電影分級編號ratingId"] = new SelectList(_context.電影分級movieRatings, "分級編號ratingId", "分級級數ratingLevel", 電影movie.電影分級編號ratingId);
            return View(電影movie);
        }

        // GET: 電影movie/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var 電影movie = await _context.電影movies
                .Include(電 => 電.系列編號series)
                .Include(電 => 電.電影分級編號rating)
                .FirstOrDefaultAsync(m => m.電影編號movieId == id);
            if (電影movie == null)
            {
                return NotFound();
            }

            return View(電影movie);
        }

        // POST: 電影movie/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var 電影movie = await _context.電影movies.FindAsync(id);
            _context.電影movies.Remove(電影movie);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool 電影movieExists(int id)
        {
            return _context.電影movies.Any(e => e.電影編號movieId == id);
        }
    }
}
