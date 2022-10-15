using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable

namespace ServerMDA.Models
{
    public partial class 演員總表actor
    {
        public 演員總表actor()
        {
            電影主演casts = new HashSet<電影主演cast>();
        }
        [DisplayName("演員編號")]
        public int 演員編號actorsId { get; set; }
        [DisplayName("中文名")]
        public string 中文名字nameCht { get; set; }
        [DisplayName("英文名")]
        public string 英文名字nameEng { get; set; }
        [DisplayName("照片")]
        public string 演員照片image { get; set; }

        public IFormFile photo { get; set; }
        public virtual ICollection<電影主演cast> 電影主演casts { get; set; }
    }
}
