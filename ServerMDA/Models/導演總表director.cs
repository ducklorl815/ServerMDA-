using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable

namespace ServerMDA.Models
{
    public partial class 導演總表director
    {
        public 導演總表director()
        {
            電影導演movieDirectors = new HashSet<電影導演movieDirector>();
        }
        [DisplayName("導演編號")]
        public int 導演編號directorId { get; set; }
        [DisplayName("中文名")]
        public string 中文名字nameCht { get; set; }
        [DisplayName("英文名")]
        public string 英文名字nameEng { get; set; }
        [DisplayName("照片")]
        public string 導演照片image { get; set; }

        public virtual ICollection<電影導演movieDirector> 電影導演movieDirectors { get; set; }
    }
}
