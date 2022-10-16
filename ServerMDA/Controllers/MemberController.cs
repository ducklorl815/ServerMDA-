using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using ServerMDA.Models;
using ServerMDA.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ServerMDA.Controllers
{
    public class MemberController : Controller
    {
        private IWebHostEnvironment _enviro;

        public MemberController(IWebHostEnvironment p)
        {
            _enviro = p;
        }
        public IActionResult List(CKeyWordViewModel model)
        {
            MDAContext db = new MDAContext();
            IEnumerable<會員member> datas = null;
            if (string.IsNullOrEmpty(model.txtkeyword))
                datas = from p in db.會員members
                        select p;
            else
                datas = db.會員members.Where(p => 
                p.名字fName.ToLower().Contains(model.txtkeyword.ToLower())|| 
                p.姓氏lName.ToLower().Contains(model.txtkeyword.ToLower())||
                p.地址address.ToLower().Contains(model.txtkeyword.ToLower())||
                p.電子信箱email.ToLower().Contains(model.txtkeyword.ToLower())||
                p.暱稱nickName.ToLower().Contains(model.txtkeyword.ToLower())||
                p.生日birthDate.ToString().ToLower().Contains(model.txtkeyword.ToLower()) ||
                p.建立時間createdTime.ToString().ToLower().Contains(model.txtkeyword.ToLower()) ||
                p.會員電話cellphone.ToLower().Contains(model.txtkeyword.ToLower()));

            return View(datas);
        }
        public ActionResult Edit(int? id)
        {
            if (id != null)
            {
                MDAContext db = new MDAContext();
                會員member member = db.會員members.FirstOrDefault(p => p.會員編號memberId == id);
                if (member != null)
                    return View(member);
            }
            return RedirectToAction("List");
        }
        [HttpPost]
        public IActionResult Edit(CMemberViewModel inMem) //post
        {
            MDAContext db = new MDAContext();
            會員member c = db.會員members.FirstOrDefault(c => c.會員編號memberId == inMem.會員編號memberId);
            if (c != null)
            {
                if (inMem.photo != null)
                {
                    string pName = Guid.NewGuid().ToString() + ".jpg";
                    c.會員照片image = pName;
                    string path = _enviro.WebRootPath + "/images/Member/" + pName;
                    inMem.photo.CopyTo(new FileStream(path, FileMode.Create));
                }
                c.會員電話cellphone = inMem.會員電話cellphone;
                c.密碼password = inMem.密碼password;
                c.姓氏lName = inMem.姓氏lName;
                c.名字fName = inMem.名字fName;
                c.暱稱nickName = inMem.暱稱nickName;
                c.生日birthDate = inMem.生日birthDate;
                c.性別gender = inMem.性別gender;
                c.電子信箱email = inMem.電子信箱email;
                c.地址address = inMem.地址address;
                c.紅利點數bonus = inMem.紅利點數bonus;
                c.正式會員formal = inMem.正式會員formal;
                c.會員權限permission = inMem.會員權限permission;
                c.建立時間createdTime = inMem.建立時間createdTime;
                db.SaveChanges();
            }
            return RedirectToAction("List");
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(會員member p, CMemberViewModel inMem)
        {
            MDAContext db = new MDAContext();

            string pName = Guid.NewGuid().ToString() + ".jpg";
            string path = _enviro.WebRootPath + "/images/Member/" + pName;
            inMem.photo.CopyTo(new FileStream(path, FileMode.Create));

            p.會員照片image = pName;

            db.會員members.Add(p);
            db.SaveChanges();
            return RedirectToAction("List");
        }
    }
}
