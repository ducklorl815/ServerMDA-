using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MailKit.Net.Smtp;
using ServerMDA.Models;
using ServerMDA.ViewModel.Report;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;

namespace ServerMDA.Controllers
{
    public class ReportController : Controller
    {
        private readonly MDAContext _MDAcontext;
        public ReportController(MDAContext MDAcontext) 
        {
            _MDAcontext = MDAcontext;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Report()
        {
            //停權 0正常 1停權
            //屏蔽 0正常 3隱藏
            var q = _MDAcontext.我的追蹤清單myFollowLists.Where(l => l.追讚倒編號actionTypeId == 3).Select(l => new CReportViewModel
            {
                我的追蹤清單編號cfId = l.我的追蹤清單編號cfId,
                對象targetId = l.對象targetId,
                對象名稱targetName = l.對象target.對象名稱targetName,
                會員編號memberId = l.會員編號memberId,
                連接編號connectId = l.連接編號connectId,
                會員編號member = l.會員編號member,
                處理狀態status = l.處理狀態status,
                檢舉理由reportReason = l.檢舉理由reportReason,
                被檢舉email = getmail(l.對象targetId,l.連接編號connectId),
                被檢舉回覆內容 = _MDAcontext.回覆樓數floors.Where(f=>f.樓數編號floorId ==l.連接編號connectId)
                .Select(k=>k.回覆內容floors).FirstOrDefault(),
                停權m= _MDAcontext.會員members.Where(f => f.會員編號memberId == l.連接編號connectId)
                .Select(k => k.會員權限permission).FirstOrDefault(),
                屏蔽c=_MDAcontext.電影評論movieComments.Where(f => f.評論編號commentId == l.連接編號connectId)
                .Select(k => k.屏蔽invisible).FirstOrDefault(),
                屏蔽r=_MDAcontext.回覆樓數floors.Where(f => f.樓數編號floorId == l.連接編號connectId)
                .Select(k => k.屏蔽invisible).FirstOrDefault(),
            }).ToList() ;

            return View(q);
        }
        public static string getmail(int target, int connect)
        {
            MDAContext db = new MDAContext();
            var a = db.我的追蹤清單myFollowLists.Where(l => l.追讚倒編號actionTypeId == 3);

            string mail = "";
            if (target == 1)
            {
                mail= db.會員members.Where(m => m.會員編號memberId == connect).Select(m => m.電子信箱email).FirstOrDefault();
            }
            else if(target==2)
            {
                mail = db.電影評論movieComments.Where(c => c.評論編號commentId == connect).Select(c => c.會員編號member.電子信箱email).FirstOrDefault();
            }
            else
            {
                var q = db.回覆樓數floors.Where(c => c.樓數編號floorId == connect).Select(c => c.會員編號memberId).FirstOrDefault();
                mail = db.會員members.Where(m => m.會員編號memberId == q).Select(m=>m.電子信箱email).FirstOrDefault();
            }
            return mail;
        }
        [HttpPost]
        public IActionResult sendmail(CReplyEmailViewModel vm)
        {
            string email = vm.emailReporter;
            MimeMessage message = new MimeMessage();
            BodyBuilder builder = new BodyBuilder();

            builder.HtmlBody = vm.emailContent;

            message.From.Add(new MailboxAddress("MDA官網", "jo3wait@outlook.com"));
            message.To.Add(new MailboxAddress("親愛的顧客", "ilovemdaofficialok@gmail.com"));//email
            message.Subject = vm.emailTitle;
            message.Body = builder.ToMessageBody();

            using (SmtpClient client = new SmtpClient())
            {
                client.Connect("smtp.outlook.com", 587, MailKit.Security.SecureSocketOptions.StartTls); //587 TLS
                client.Authenticate("jo3wait@outlook.com", "msit143group3");
                client.Send(message);
                client.Disconnect(true);
            }

            HttpContext.Session.SetString(CDictionaryReport.SK_導回的tab, vm.type);
            var q = _MDAcontext.我的追蹤清單myFollowLists.Where(l => l.我的追蹤清單編號cfId == vm.cfid).FirstOrDefault();
            q.處理狀態status = 1;
            _MDAcontext.SaveChanges();


            return RedirectToAction("Report");
        }
        [HttpPost]
        public IActionResult sendmany([FromBody]List<CSendManyViewModel> vm) //CSendManyViewModel
        {
            //var vm = JsonSerializer.Deserialize<List<CSendManyViewModel>>(vms);
            //foreach (var i in vm)
            //{
            //    string email = i.mail;
            //    MimeMessage message = new MimeMessage();
            //    BodyBuilder builder = new BodyBuilder();

            //    builder.HtmlBody = $"親愛的會員您好，<br/>" +
            //        $"&emsp; 感谢您對認為違反我們社群守則的內容提出檢舉。<br/>" +
            //        $"&emsp; 對於讓MDA成為安全且友好的環境來說,您提出的檢舉是相當重要的一環。<br/>" +
            //        $"&emsp; 經審查並未發現有違反社群守則之處，<br/>&emsp; 若您認為應再次進行調查,請回覆此封信件告知我們。<br/>" +
            //        $"&emsp; 謝謝您！";

            //    message.From.Add(new MailboxAddress("MDA官網", "jo3wait@outlook.com"));
            //    message.To.Add(new MailboxAddress("親愛的顧客", "ilovemdaofficialok@gmail.com"));//email
            //    message.Subject = "MDA會員檢舉後續處理情形";
            //    message.Body = builder.ToMessageBody();

            //    using (SmtpClient client = new SmtpClient())
            //    {
            //        client.Connect("smtp.outlook.com", 587, MailKit.Security.SecureSocketOptions.StartTls); //587 TLS
            //        client.Authenticate("jo3wait@outlook.com", "msit143group3");
            //        client.Send(message);
            //        client.Disconnect(true);
            //    }
            //}

            var q = _MDAcontext.我的追蹤清單myFollowLists.Select(l=>l);
            foreach(var i in vm)
            {
                var a = q.Where(l => l.我的追蹤清單編號cfId == i.id).FirstOrDefault();
                if(a!=null)
                    a.處理狀態status = 1;
            }            
            _MDAcontext.SaveChanges();
            
            HttpContext.Session.SetString(CDictionaryReport.SK_導回的tab, vm[0].tab);
            return RedirectToAction("Report");
        }

        public IActionResult suspendMember(int id )
        {
            會員member q = _MDAcontext.會員members.Where(r => r.會員編號memberId == id).FirstOrDefault();
            if (q.會員權限permission == 0)
                q.會員權限permission = 1;
            else if (q.會員權限permission == 1)
                q.會員權限permission = 0;
            _MDAcontext.SaveChanges();
            return Content("s", "text/plain");
        }
        public IActionResult invisibleComment(int id)
        {
            電影評論movieComment q = _MDAcontext.電影評論movieComments.Where(r => r.評論編號commentId == id).FirstOrDefault();
            if (q.屏蔽invisible == 0)
                q.屏蔽invisible = 3;
            else if (q.屏蔽invisible == 3)
                q.屏蔽invisible = 0;
            _MDAcontext.SaveChanges();
            return Content("s", "text/plain");
        }
        public IActionResult invisibleReply(int id)
        {
            回覆樓數floor q = _MDAcontext.回覆樓數floors.Where(r => r.樓數編號floorId == id).FirstOrDefault();
            if (q.屏蔽invisible == 0)
                q.屏蔽invisible = 3;
            else if (q.屏蔽invisible == 3)
                q.屏蔽invisible = 0;
            _MDAcontext.SaveChanges();
            return Content("s", "text/plain");
        }
        public IActionResult changeUnsolve(int id, string tab)
        {
            我的追蹤清單myFollowList q = _MDAcontext.我的追蹤清單myFollowLists.First(l => l.我的追蹤清單編號cfId == id);
            q.處理狀態status = 0;
            _MDAcontext.SaveChanges();
            HttpContext.Session.SetString(CDictionaryReport.SK_導回的tab, tab);
            return RedirectToAction("Report");
        }
    }
}
