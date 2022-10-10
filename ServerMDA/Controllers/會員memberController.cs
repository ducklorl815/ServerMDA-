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
    public class 會員memberController : Controller
    {
        private readonly MDAContext _context;

        public 會員memberController(MDAContext context)
        {
            _context = context;
        }

        // GET: 會員member
        public async Task<IActionResult> Index()
        {
            var mDAContext = _context.會員members.Include(會 => 會.性別genderNavigation).Include(會 => 會.會員權限permissionNavigation);
            return View(await mDAContext.ToListAsync());
        }

        // GET: 會員member/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var 會員member = await _context.會員members
                .Include(會 => 會.性別genderNavigation)
                .Include(會 => 會.會員權限permissionNavigation)
                .FirstOrDefaultAsync(m => m.會員編號memberId == id);
            if (會員member == null)
            {
                return NotFound();
            }

            return View(會員member);
        }

        // GET: 會員member/Create
        public IActionResult Create()
        {
            ViewData["性別gender"] = new SelectList(_context.性別genders, "性別gender1", "性別名稱genderName");
            ViewData["會員權限permission"] = new SelectList(_context.會員權限permissions, "會員權限permission1", "權限名稱permissionName");
            return View();
        }

        // POST: 會員member/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("會員編號memberId,會員電話cellphone,密碼password,姓氏lName,名字fName,暱稱nickName,生日birthDate,性別gender,電子信箱email,地址address,紅利點數bonus,正式會員formal,會員權限permission,會員照片image,建立時間createdTime")] 會員member 會員member)
        {
            if (ModelState.IsValid)
            {
                _context.Add(會員member);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["性別gender"] = new SelectList(_context.性別genders, "性別gender1", "性別名稱genderName", 會員member.性別gender);
            ViewData["會員權限permission"] = new SelectList(_context.會員權限permissions, "會員權限permission1", "權限名稱permissionName", 會員member.會員權限permission);
            return View(會員member);
        }

        // GET: 會員member/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var 會員member = await _context.會員members.FindAsync(id);
            if (會員member == null)
            {
                return NotFound();
            }
            ViewData["性別gender"] = new SelectList(_context.性別genders, "性別gender1", "性別名稱genderName", 會員member.性別gender);
            ViewData["會員權限permission"] = new SelectList(_context.會員權限permissions, "會員權限permission1", "權限名稱permissionName", 會員member.會員權限permission);
            return View(會員member);
        }

        // POST: 會員member/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("會員編號memberId,會員電話cellphone,密碼password,姓氏lName,名字fName,暱稱nickName,生日birthDate,性別gender,電子信箱email,地址address,紅利點數bonus,正式會員formal,會員權限permission,會員照片image,建立時間createdTime")] 會員member 會員member)
        {
            if (id != 會員member.會員編號memberId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(會員member);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!會員memberExists(會員member.會員編號memberId))
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
            ViewData["性別gender"] = new SelectList(_context.性別genders, "性別gender1", "性別名稱genderName", 會員member.性別gender);
            ViewData["會員權限permission"] = new SelectList(_context.會員權限permissions, "會員權限permission1", "權限名稱permissionName", 會員member.會員權限permission);
            return View(會員member);
        }

        // GET: 會員member/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var 會員member = await _context.會員members
                .Include(會 => 會.性別genderNavigation)
                .Include(會 => 會.會員權限permissionNavigation)
                .FirstOrDefaultAsync(m => m.會員編號memberId == id);
            if (會員member == null)
            {
                return NotFound();
            }

            return View(會員member);
        }

        // POST: 會員member/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var 會員member = await _context.會員members.FindAsync(id);
            _context.會員members.Remove(會員member);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool 會員memberExists(int id)
        {
            return _context.會員members.Any(e => e.會員編號memberId == id);
        }
        public FileResult ShowPhoto(int id)
        {
            會員member member = _context.會員members.Find(id);
            byte[] context = member.會員照片image;
            return File(context, "image/jpeg");
        }
    }
}

