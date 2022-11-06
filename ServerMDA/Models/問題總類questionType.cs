using System;
using System.Collections.Generic;

#nullable disable

namespace ServerMDA.Models
{
    public partial class 問題總類questionType
    {
        public 問題總類questionType()
        {
            一般資訊generaInformations = new HashSet<一般資訊generaInformation>();
            會員問題memQas = new HashSet<會員問題memQa>();
        }

        public int 問題總類編號questionTypeId { get; set; }
        public string 問題分類questionClassification { get; set; }

        public virtual ICollection<一般資訊generaInformation> 一般資訊generaInformations { get; set; }
        public virtual ICollection<會員問題memQa> 會員問題memQas { get; set; }
    }
}
