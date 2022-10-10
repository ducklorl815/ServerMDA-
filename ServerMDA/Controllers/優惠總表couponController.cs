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
    public class 優惠總表couponController : Controller
    {
        private readonly MDAContext _context;

        public 優惠總表couponController(MDAContext context)
        {
            _context = context;
        }

        // GET: 優惠總表coupon
        public async Task<IActionResult> Index()
        {
            return View(await _context.優惠總表coupons.ToListAsync());
        }

        // GET: 優惠總表coupon/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var 優惠總表coupon = await _context.優惠總表coupons
                .FirstOrDefaultAsync(m => m.優惠編號couponId == id);
            if (優惠總表coupon == null)
            {
                return NotFound();
            }

            return View(優惠總表coupon);
        }

        // GET: 優惠總表coupon/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: 優惠總表coupon/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("優惠編號couponId,優惠名稱couponName,優惠折扣couponDiscount,優惠代碼couponCode,優惠截止日期couponDueDate,優惠所需紅利bonusCost")] 優惠總表coupon 優惠總表coupon)
        {
            if (ModelState.IsValid)
            {
                _context.Add(優惠總表coupon);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(優惠總表coupon);
        }

        // GET: 優惠總表coupon/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var 優惠總表coupon = await _context.優惠總表coupons.FindAsync(id);
            if (優惠總表coupon == null)
            {
                return NotFound();
            }
            return View(優惠總表coupon);
        }

        // POST: 優惠總表coupon/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("優惠編號couponId,優惠名稱couponName,優惠折扣couponDiscount,優惠代碼couponCode,優惠截止日期couponDueDate,優惠所需紅利bonusCost")] 優惠總表coupon 優惠總表coupon)
        {
            if (id != 優惠總表coupon.優惠編號couponId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(優惠總表coupon);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!優惠總表couponExists(優惠總表coupon.優惠編號couponId))
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
            return View(優惠總表coupon);
        }

        // GET: 優惠總表coupon/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var 優惠總表coupon = await _context.優惠總表coupons
                .FirstOrDefaultAsync(m => m.優惠編號couponId == id);
            if (優惠總表coupon == null)
            {
                return NotFound();
            }

            return View(優惠總表coupon);
        }

        // POST: 優惠總表coupon/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var 優惠總表coupon = await _context.優惠總表coupons.FindAsync(id);
            _context.優惠總表coupons.Remove(優惠總表coupon);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool 優惠總表couponExists(int id)
        {
            return _context.優惠總表coupons.Any(e => e.優惠編號couponId == id);
        }
    }
}
