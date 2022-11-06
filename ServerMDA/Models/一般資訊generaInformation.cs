using System;
using System.Collections.Generic;

#nullable disable

namespace ServerMDA.Models
{
    public partial class 一般資訊generaInformation
    {
        public int 一般資訊generaInformationId { get; set; }
        public string 問題question { get; set; }
        public string 答案answer { get; set; }
        public int 問題總類編號questionTypeId { get; set; }

        public virtual 問題總類questionType 問題總類編號questionType { get; set; }
    }
}
