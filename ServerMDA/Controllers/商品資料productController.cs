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
    public class 商品資料productController : Controller
    {
        private readonly MDAContext _context;

        public 商品資料productController(MDAContext context)
        {
            _context = context;
        }

        // GET: 商品資料product
        public async Task<IActionResult> Index()
        {
            var mDAContext = _context.商品資料products.Include(商 => 商.電影院編號theater);
            return View(await mDAContext.ToListAsync());
        }

        // GET: 商品資料product/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var 商品資料product = await _context.商品資料products
                .Include(商 => 商.電影院編號theater)
                .FirstOrDefaultAsync(m => m.商品編號productId == id);
            if (商品資料product == null)
            {
                return NotFound();
            }

            return View(商品資料product);
        }

        // GET: 商品資料product/Create
        public IActionResult Create()
        {
            ViewData["電影院編號theaterId"] = new SelectList(_context.電影院theaters, "電影院編號theaterId", "地址address");
            return View();
        }

        // POST: 商品資料product/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("商品編號productId,商品名稱productName,商品價格productPrice,電影院編號theaterId,商品圖片image")] 商品資料product 商品資料product)
        {
            if (ModelState.IsValid)
            {
                _context.Add(商品資料product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["電影院編號theaterId"] = new SelectList(_context.電影院theaters, "電影院編號theaterId", "地址address", 商品資料product.電影院編號theaterId);
            return View(商品資料product);
        }

        // GET: 商品資料product/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var 商品資料product = await _context.商品資料products.FindAsync(id);
            if (商品資料product == null)
            {
                return NotFound();
            }
            ViewData["電影院編號theaterId"] = new SelectList(_context.電影院theaters, "電影院編號theaterId", "地址address", 商品資料product.電影院編號theaterId);
            return View(商品資料product);
        }

        // POST: 商品資料product/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("商品編號productId,商品名稱productName,商品價格productPrice,電影院編號theaterId,商品圖片image")] 商品資料product 商品資料product)
        {
            if (id != 商品資料product.商品編號productId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(商品資料product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!商品資料productExists(商品資料product.商品編號productId))
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
            ViewData["電影院編號theaterId"] = new SelectList(_context.電影院theaters, "電影院編號theaterId", "地址address", 商品資料product.電影院編號theaterId);
            return View(商品資料product);
        }

        // GET: 商品資料product/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var 商品資料product = await _context.商品資料products
                .Include(商 => 商.電影院編號theater)
                .FirstOrDefaultAsync(m => m.商品編號productId == id);
            if (商品資料product == null)
            {
                return NotFound();
            }

            return View(商品資料product);
        }

        // POST: 商品資料product/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var 商品資料product = await _context.商品資料products.FindAsync(id);
            _context.商品資料products.Remove(商品資料product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool 商品資料productExists(int id)
        {
            return _context.商品資料products.Any(e => e.商品編號productId == id);
        }
        public FileResult ShowPhoto(int id)
        {
            商品資料product product = _context.商品資料products.Find(id);
            byte[] context = product.商品圖片image;
            return File(context, "image/jpeg");
        }
    }
}
