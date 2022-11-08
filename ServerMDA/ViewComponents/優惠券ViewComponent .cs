using Microsoft.AspNetCore.Mvc;
using ServerMDA.Models;
using ServerMDA.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerMDA.ViewComponents
{
    public class 優惠券ViewComponent : ViewComponent
    {
        private MDAContext _MDA;

        public async Task<IViewComponentResult> InvokeAsync(List<CQandAViewModel> datas)
        {
            return View(datas);
        }
    }
}
