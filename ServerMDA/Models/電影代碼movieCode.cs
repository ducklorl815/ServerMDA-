﻿using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable

namespace ServerMDA.Models
{
    public partial class 電影代碼movieCode
    {
        public 電影代碼movieCode()
        {
            場次screenings = new HashSet<場次screening>();
        }
        [DisplayName("電影代碼編號")]
        public int 電影代碼編號movieCodeId { get; set; }
        [DisplayName("電影編號")]
        public int 電影編號movieId { get; set; }
        [DisplayName("語言編號")]
        public int 語言編號languageId { get; set; }

        public virtual 電影語言movieLanguage 語言編號language { get; set; }
        public virtual 電影movie 電影編號movie { get; set; }
        public virtual ICollection<場次screening> 場次screenings { get; set; }
    }
}
