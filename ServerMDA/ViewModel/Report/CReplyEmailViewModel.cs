using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerMDA.ViewModel.Report
{
    public class CReplyEmailViewModel
    {
        public string emailReporter { get; set; }
        public string emailTitle { get; set; }
        public string emailContent { get; set; }
        public string type { get; set; }
        public int cfid { get; set; }
    }
}
