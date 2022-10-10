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
    public class 電影評論movieCommentController : Controller
    {
        private readonly MDAContext _context;

        public 電影評論movieCommentController(MDAContext context)
        {
            _context = context;
        }

        // GET: 電影評論movieComment
        public async Task<IActionResult> Index()
        {
            var mDAContext = _context.電影評論movieComments.Include(電 => 電.電影編號movie);
            return View(await mDAContext.ToListAsync());
        }

        // GET: 電影評論movieComment/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var 電影評論movieComment = await _context.電影評論movieComments
                .Include(電 => 電.電影編號movie)
                .FirstOrDefaultAsync(m => m.評論編號commentId == id);
            if (電影評論movieComment == null)
            {
                return NotFound();
            }

            return View(電影評論movieComment);
        }

        // GET: 電影評論movieComment/Create
        public IActionResult Create()
        {
            ViewData["電影編號movieId"] = new SelectList(_context.電影movies, "電影編號movieId", "英文標題titleEng");
            return View();
        }

        // POST: 電影評論movieComment/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("評論編號commentId,會員編號memberId,電影編號movieId,評分rate,期待度anticipation,評論標題commentTitle,評論內容comments,發佈時間commentTime,觀影日期viewingTime,觀影方式source,公開等級編號publicId,是否開放討論串oxFloor,屏蔽invisible,檢舉report")] 電影評論movieComment 電影評論movieComment)
        {
            if (ModelState.IsValid)
            {
                _context.Add(電影評論movieComment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["電影編號movieId"] = new SelectList(_context.電影movies, "電影編號movieId", "英文標題titleEng", 電影評論movieComment.電影編號movieId);
            return View(電影評論movieComment);
        }

        // GET: 電影評論movieComment/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var 電影評論movieComment = await _context.電影評論movieComments.FindAsync(id);
            if (電影評論movieComment == null)
            {
                return NotFound();
            }
            ViewData["電影編號movieId"] = new SelectList(_context.電影movies, "電影編號movieId", "英文標題titleEng", 電影評論movieComment.電影編號movieId);
            return View(電影評論movieComment);
        }

        // POST: 電影評論movieComment/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("評論編號commentId,會員編號memberId,電影編號movieId,評分rate,期待度anticipation,評論標題commentTitle,評論內容comments,發佈時間commentTime,觀影日期viewingTime,觀影方式source,公開等級編號publicId,是否開放討論串oxFloor,屏蔽invisible,檢舉report")] 電影評論movieComment 電影評論movieComment)
        {
            if (id != 電影評論movieComment.評論編號commentId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(電影評論movieComment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!電影評論movieCommentExists(電影評論movieComment.評論編號commentId))
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
            ViewData["電影編號movieId"] = new SelectList(_context.電影movies, "電影編號movieId", "英文標題titleEng", 電影評論movieComment.電影編號movieId);
            return View(電影評論movieComment);
        }

        // GET: 電影評論movieComment/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var 電影評論movieComment = await _context.電影評論movieComments
                .Include(電 => 電.電影編號movie)
                .FirstOrDefaultAsync(m => m.評論編號commentId == id);
            if (電影評論movieComment == null)
            {
                return NotFound();
            }

            return View(電影評論movieComment);
        }

        // POST: 電影評論movieComment/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var 電影評論movieComment = await _context.電影評論movieComments.FindAsync(id);
            _context.電影評論movieComments.Remove(電影評論movieComment);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool 電影評論movieCommentExists(int id)
        {
            return _context.電影評論movieComments.Any(e => e.評論編號commentId == id);
        }
    }
}
