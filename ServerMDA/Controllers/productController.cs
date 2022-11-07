using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ServerMDA.Models;
using ServerMDA.ViewModel;
using ServerMDA.ViewModel.WenViewModel;

namespace ServerMDA.Controllers
{
    public class productController : Controller
    {
        private readonly MDAContext _context;
        private IWebHostEnvironment _enviro;


        public productController(MDAContext context, IWebHostEnvironment p)
        {
            _context = context;
            _enviro = p;

        }

        //Product開頭都是後台
        int _count;
        public int count
        {
            get { return _count; }
            set { _count = value; }
        }
        public IActionResult ProductSearchKeyword()
        {
            return View();
        }
        public IActionResult testItem()
        {
            var query = from m in _context.電影院theaters
                        from p in m.商品資料products
                        group p by p.電影院編號theater.電影院名稱theaterName into g
                        select new
                        {
                            TheaterName = g.Key,
                            ProductCount = g.Count()
                        };


            return Json(query);
        }
        public IActionResult PrdSearch(string keyword)
        {
            var product = _context.商品資料products
                .Where(p => p.商品名稱productName.Contains(keyword) ||
                            p.商品介紹introduce.Contains(keyword) ||
                            p.電影院編號theater.電影院名稱theaterName.Contains(keyword)
                       )
                .Select(p => new
                {
                    p.電影院編號theater.電影院名稱theaterName,
                    p.商品名稱productName,
                    p.商品價格productPrice,
                    p.商品介紹introduce,
                    p.類別category,
                    p.商品圖片路徑imagePath
                });
            return Json(product);
        }
        public IActionResult ProductList(CMyListPrd cp)
        {
            //model WenPrj.ViewModel.CMyListPrd
            if (cp.產品列表 == null)  
            {
                cp = new CMyListPrd();
                cp.產品列表 = (from c in _context.商品資料products
                           orderby c.商品編號productId descending
                           select new 產品格式
                           {
                               商品編號productId = c.商品編號productId,
                               商品名稱productName = c.商品名稱productName,
                               商品價格productPrice = c.商品價格productPrice,
                               商品圖片路徑imagePath = c.商品圖片路徑imagePath,
                               商品介紹introduce = c.商品介紹introduce,
                               類別category = c.類別category,
                               電影院名稱theaterName = c.電影院編號theater.電影院名稱theaterName

                           }).ToList();//.Take(5).ToList();
                                       // var q=cp.產品列表.First();
            }
            return View(cp);

        }
        public IActionResult ReceiptList(CRList v)
        {          

            if (v.購買的明細表 == null)
            {
                v = new CRList();
                v.購買的明細表 = (from c in _context.購買商品明細receipts                          
                           select new 明細
                           {
                               購買商品明細編號receiptId=c.購買商品明細編號receiptId,
                               商品編號productId =c.商品編號productId,
                               商品名稱productName = c.商品編號product.商品名稱productName,
                               類別category=c.商品編號product.類別category,
                               訂單編號orderId=c.訂單編號orderId,
                               商品價格productPrice=c.商品編號product.商品價格productPrice,
                               商品數量qty=c.商品數量qty,
                               電影院名稱theaterName =c.商品編號product.電影院編號theater.電影院名稱theaterName
                           }).ToList();                                    
            }
            return View(v);
        }


        public IActionResult Pag(/*CMyListPrd mytx,*/int mytx)
        {
            //int count = 0;
            //if (Session["COUNT"] != null)
            //    count = (int)Session["COUNT"];
            //count++;
            //Session["COUNT"] = count;q           
            // count++;

            CMyListPrd cp = new CMyListPrd();            
            cp.產品列表 = (from c in _context.商品資料products
                       orderby c.商品編號productId descending
                       select new 產品格式
                       {
                           商品編號productId = c.商品編號productId,
                           商品名稱productName = c.商品名稱productName,
                           商品價格productPrice = c.商品價格productPrice,
                           商品圖片路徑imagePath = c.商品圖片路徑imagePath,
                           商品介紹introduce = c.商品介紹introduce,
                           類別category = c.類別category,
                           電影院名稱theaterName = c.電影院編號theater.電影院名稱theaterName,


                       }).Skip(mytx - mytx).Take(mytx).ToList();//.Take(mytx).ToList();
            cp.產品列表.Count();
            //var query = from a in _context.商品資料products.Take(count * tx).Skip((count - 1) * tx)
            //            select a;
            //return Json(query);
            //return View(cp);
            return View("ProductList",cp);
        }
      [HttpGet]
        public IActionResult ProductDelete(int? Inprod)
        {
            if (Inprod != null)
            {
                商品資料product prod = _context.商品資料products.FirstOrDefault(p => p.商品編號productId == Inprod);
                if (prod != null)
                {
                    _context.商品資料products.Remove(prod);
                    _context.SaveChanges();
                }
            }
            return RedirectToAction("ProductList");
        }

        public IActionResult ProductEdit(int? id)
        {
            //商品資料product p = _context.商品資料products.FirstOrDefault(t => t.商品編號productId == id);
            //if (p != null)
            //{
            //    return View(p);
            //}
            //return RedirectToAction("ProductList");
            if (id == null)
            {
                return NotFound();
            }

            var 商品資料product = _context.商品資料products.FirstOrDefault(t => t.商品編號productId == id);
            if (商品資料product != null)
            {

                ViewData["電影院編號theaterId"] = new SelectList(_context.電影院theaters, "電影院編號theaterId", "電影院名稱theaterName", 商品資料product.電影院編號theaterId);

                return View(商品資料product);
            }
            else
            {
                return NotFound();
            }
        }
        [HttpPost]
        public IActionResult ProductEdit(CProd Inprod)
        {
            商品資料product p = _context.商品資料products.FirstOrDefault(t => t.商品編號productId == Inprod.商品編號productId);

            if (p != null)
            {
                if (Inprod.photo != null)
                {
                    string pName = Guid.NewGuid().ToString() + ".jpg";
                    p.商品圖片路徑imagePath = pName;
                    string path = _enviro.WebRootPath + "/images/" + "/WenProduct/" + pName;
                    Inprod.photo.CopyTo(new FileStream(path, FileMode.Create));
                }
                p.商品名稱productName = Inprod.商品名稱productName;
                p.商品價格productPrice = Inprod.商品價格productPrice;
                p.類別category = Inprod.類別category;
                p.商品介紹introduce = Inprod.商品介紹introduce;
                p.電影院編號theaterId = Inprod.電影院編號theaterId;

                _context.SaveChanges();

                var 商品資料product = _context.商品資料products.FirstOrDefault(t => t.商品編號productId == Inprod.商品編號productId);
                if (商品資料product != null)
                {
                    ViewData["電影院編號theaterId"] = new SelectList(_context.電影院theaters, "電影院編號theaterId", "電影院名稱theaterName", 商品資料product.電影院編號theaterId);
                    //return View(商品資料product);
                    return RedirectToAction("ProductList");

                }
                else
                {
                    return NotFound();
                }

            }

            return RedirectToAction("ProductList");
        }
   
        public IActionResult ProductCreate()
        {
            
            ViewData["電影院編號theaterId"] = new SelectList(_context.電影院theaters, "電影院編號theaterId", "電影院名稱theaterName");
            return View();
        }
        [HttpPost]
        public IActionResult ProductCreate(CProd Inprod)
        {
            ViewData["電影院編號theaterId"] = new SelectList(_context.電影院theaters, "電影院編號theaterId", "電影院名稱theaterName");

            商品資料product p = new 商品資料product();
            if (Inprod.photo != null)
            {
                string pName = Guid.NewGuid().ToString() + ".jpg";
                p.商品圖片路徑imagePath = pName;
                string path = _enviro.WebRootPath + "/images/" + "/WenProduct/" + pName;
                Inprod.photo.CopyTo(new FileStream(path, FileMode.Create));
            }
            p.商品名稱productName = Inprod.商品名稱productName;
            p.商品價格productPrice = Inprod.商品價格productPrice;
            p.類別category = Inprod.類別category;
            p.商品介紹introduce = Inprod.商品介紹introduce;
            p.電影院編號theaterId = Inprod.電影院編號theaterId;

            _context.商品資料products.Add(p);
            _context.SaveChanges();
            return RedirectToAction("ProductList");
        }

        public IActionResult ProductNext()
        {
            var tx = 5;
            count += 1;
            var datas = from p in _context.商品資料products
                        orderby p.商品編號productId descending
                        select p;
            var q = from a in datas.Take(count * tx).Skip((5 - 1) * tx)
                    select a;
            return View(q);

        }
        public IActionResult ProductChart()
        {
            return View();
        }

        public IActionResult ProductChartTwo()
        {
            var p = from m in _context.電影院theaters
                    select m;
            
            return View(p);
        }
       
        public IActionResult saleChart(string theatername)
        {  
            var query = _context.購買商品明細receipts
                .Where(n => n.商品編號product.電影院編號theater.電影院名稱theaterName.Equals(theatername))
                .GroupBy(n => new { n.商品編號product.商品名稱productName })
                .Select(p => new {                    
                    電影院= p.Key,
                    商品名稱=p.Key.商品名稱productName,
                    數量=p.Select(n=>n.商品數量qty).Sum()
                    });
            return Json(query);
            //.GroupBy(n => new {n.商品編號product.商品名稱productName,n.商品編號product.電影院編號theater.電影院名稱theaterName})

            // var q = _context.購買商品明細receipts
            //    .GroupBy(n => new { n.商品編號product.商品名稱productName, n.商品編號product.電影院編號theater.電影院名稱theaterName })
            //    .Select(p => new
            //    {
            //        電影院 = p.Key.商品名稱productName,
            //        商品名稱 = p.Key.商品名稱productName,
            //        數量 = p.Select(n => n.商品數量qty).Sum(),
            //        單價 = p.Select(n => n.商品編號product.商品價格productPrice).FirstOrDefault(),
            //        銷售金額 = p.Select(n => n.商品數量qty).Sum() * p.Select(n => n.商品編號product.商品價格productPrice).FirstOrDefault()
            //    });
            //// var q2 = q.Where(n => n.商品編號product.電影院編號theater.電影院名稱theaterName.Equals(theatername));
            //var q2=q.Where(n => n.電影院.Equals(theatername));
            // return Json(q);
        }

        public IActionResult ProductChartSample()
        {
            return View();
        }




        // GET: product
        public async Task<IActionResult> Index()
        {
            var mDAContext = _context.商品資料products.Include(商 => 商.電影院編號theater);
            return View(await mDAContext.ToListAsync());
        }

        // GET: product/Details/5
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

        // GET: product/Create
        public IActionResult Create()
        {
            ViewData["電影院編號theaterId"] = new SelectList(_context.電影院theaters, "電影院編號theaterId", "電影院名稱theaterName");
            return View();
        }

        // POST: product/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("商品編號productId,商品名稱productName,商品價格productPrice,電影院編號theaterId,商品圖片image,商品圖片路徑imagePath,商品介紹introduce,類別category")] 商品資料product 商品資料product)
        {
            if (ModelState.IsValid)
            {
                _context.Add(商品資料product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["電影院編號theaterId"] = new SelectList(_context.電影院theaters, "電影院編號theaterId", "電影院名稱theaterName", 商品資料product.電影院編號theaterId);
            return View(商品資料product);
        }

        // GET: product/Edit/5
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
            ViewData["電影院編號theaterId"] = new SelectList(_context.電影院theaters, "電影院編號theaterId", "電影院名稱theaterName", 商品資料product.電影院編號theaterId);
            return View(商品資料product); //原本的自動建立
            //return RedirectToAction("ProductList"); //自已修改的
        }

        // POST: product/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken] //WenProdEditView myprod
        public async Task<IActionResult> Edit(int id, [Bind("商品編號productId,商品名稱productName,商品價格productPrice,電影院編號theaterId,商品圖片image,商品圖片路徑imagePath,商品介紹introduce,類別category")] 商品資料product 商品資料product)
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
                //return RedirectToAction(nameof(Index));//原本自動建立的
                return RedirectToAction(nameof(ProductList));//自己修改的
            }
            ViewData["電影院編號theaterId"] = new SelectList(_context.電影院theaters, "電影院編號theaterId", "電影院名稱theaterName", 商品資料product.電影院編號theaterId);
            return View(商品資料product);
        }

        // GET: product/Delete/5
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

        // POST: product/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var 商品資料product = await _context.商品資料products.FindAsync(id);
            _context.商品資料products.Remove(商品資料product);
            await _context.SaveChangesAsync();
            //return RedirectToAction(nameof(Index));//原本自動建立的
            return RedirectToAction(nameof(ProductList));//自己修改的
        }

        private bool 商品資料productExists(int id)
        {
            return _context.商品資料products.Any(e => e.商品編號productId == id);
        }
    }
}
