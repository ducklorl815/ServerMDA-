using ServerMDA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerMDA.ViewModel.Report
{
    public class CReportViewModel
    {
        public int 我的追蹤清單編號cfId { get; set; }
        public int 會員編號memberId { get; set; }
        public int 對象targetId { get; set; }
        public int 連接編號connectId { get; set; }
        public string 檢舉理由reportReason { get; set; }
        public string 對象名稱targetName { get; set; }
        public int? 處理狀態status { get; set; }
        public 會員member 會員編號member { get; set; }
        public string 被檢舉email { get; set; }

        public string 被檢舉回覆內容 { get; set; }
        public int? 停權m { get; set; } //0正常 1停權
        public int? 屏蔽c { get; set; } //0正常 3隱藏
        public int? 屏蔽r { get; set; }
    }

}
