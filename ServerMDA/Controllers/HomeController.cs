using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ServerMDA.Models;
using ServerMDA.ViewModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace ServerMDA.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(CLoginViewModel vModel)
        {
            會員member mem = (new MDAContext()).會員members.FirstOrDefault(c => c.會員電話cellphone.Equals(vModel.txtAccount));
            if (mem != null)
            {
                if (mem.密碼password.Equals(vModel.txtPassword))
                {
                    string jsonUser = JsonSerializer.Serialize(mem);
                    HttpContext.Session.SetString(CDictionary.SK_LOGINED_USER, jsonUser);
                    return RedirectToAction("List","HomePage");
                }
            }

            return View();
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Remove(CDictionary.SK_LOGINED_USER);
            return RedirectToAction("Login");
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
