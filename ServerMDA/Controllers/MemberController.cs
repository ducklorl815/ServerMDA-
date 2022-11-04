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
        public IActionResult List()
        {
            MDAContext db = new MDAContext();
            List<CMemberViewModel> datas = null;
            var C = db.優惠總表coupons;
            var D = db.會員權限permissions;
            datas = db.會員members.Select
            (p => new CMemberViewModel
            {
                member = p,
                性別名稱genderName = p.性別genderNavigation.性別名稱genderName,
                權限名稱permissionName = p.會員權限permissionNavigation.權限名稱permissionName,
                優惠總表coupon = C.ToList(),
                會員權限PermissionS = D.ToList()
            }).ToList();

            return View(datas);
        }
        public ActionResult Edit(int? id)
        {
            MDAContext db = new MDAContext();
            CMemberViewModel datas = null;
            var gender = db.性別genders.Select(p => p.性別名稱genderName).ToList();
            var permission = db.會員權限permissions.Select(p => p.權限名稱permissionName).ToList();
            var addresses = db.地址addresses.Select(p => p.City).Distinct().ToList();
            datas = db.會員members.Where(p => p.會員編號memberId == id).Select
                (p => new CMemberViewModel
                {
                    member = p,
                    性別名稱genderName = p.性別genderNavigation.性別名稱genderName,
                    權限名稱permissionName = p.會員權限permissionNavigation.權限名稱permissionName,

                }).FirstOrDefault();
            datas.ListGender = gender;
            datas.ListPermission = permission;
            datas.ListAddresses = addresses;
            return View(datas);
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
                c.性別gender = db.性別genders.FirstOrDefault(p => p.性別名稱genderName == inMem.性別名稱genderName).性別gender1;
                c.會員權限permission = db.會員權限permissions.FirstOrDefault(p => p.權限名稱permissionName == inMem.權限名稱permissionName).會員權限permission1;

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
        public ActionResult Details(int? id)
        {
            MDAContext db = new MDAContext();
            CMemberViewModel datas = null;
            datas = db.會員members.Where(p => p.會員編號memberId == id).Select
                (p => new CMemberViewModel
                {
                    member = p,
                    性別名稱genderName = p.性別genderNavigation.性別名稱genderName,
                    權限名稱permissionName = p.會員權限permissionNavigation.權限名稱permissionName,
                }).FirstOrDefault();
            return View(datas);
        }
    }
}
