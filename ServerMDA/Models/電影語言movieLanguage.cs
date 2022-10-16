using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable

namespace ServerMDA.Models
{
    public partial class 電影語言movieLanguage
    {
        public 電影語言movieLanguage()
        {
            電影代碼movieCodes = new HashSet<電影代碼movieCode>();
        }
        [DisplayName("語言編號")]
        public int 語言編號languageId { get; set; }
        [DisplayName("語言名稱")]
        public string 語言名稱languageName { get; set; }

        public virtual ICollection<電影代碼movieCode> 電影代碼movieCodes { get; set; }
    }
}
