using ServerMDA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerMDA.ViewModel
{
    public class CQandAViewModel
    {
        public List<一般資訊generaInformation> 一般資訊GeneraInformation { get; set; }
        public List<會員問題memQa> 會員問題memQa { get; set; }       
        public List<評分問題rateQa> 評分問題rateQa { get; set; }
        public List<評論問題commentQa> 評論問題commentQa { get; set; }
        public List<加入片單addlistQa> 加入片單addlistQa { get; set; }
        public List<訂票問題orderticketQa> 訂票問題orderticketQa { get; set; }
        public List<取票問題taketicketQa> 取票問題taketicketQa { get; set; }
        public List<退票問題refundQa> 退票問題refundQa { get; set; }
        public List<優惠券couponQa> 優惠券couponQa { get; set; }
        public List<購物問題shopQa> 購物問題shopQa { get; set; }
        public string 問題Question { get; set; }
        public string 答案Answer { get; set; }              
        public int 一般資訊GeneraInformationID { get; set; }

        public string 會員問題Question { get; set; }
        public string 會員答案Answer { get; set; }
        public int 會員問題memQaId { get; set; }

        public string 評分問題Question { get; set; }
        public string 評分答案Answer { get; set; }
        public int 評分問題rateQaId { get; set; }

        public string 評論問題Question { get; set; }
        public string 評論答案Answer { get; set; }
        public int 評論問題commentQaId { get; set; }

        public int 加入片單addlistQaId { get; set; }
        public string 加入片單Question { get; set; }
        public string 加入片單Answer { get; set; }

        public int 訂票問題orderticketQaId { get; set; }
        public string 訂票問題Question { get; set; }
        public string 訂票問題Answer { get; set; }

        public int 取票問題taketicketQaId { get; set; }
        public string 取票問題Question { get; set; }
        public string 取票問題Answer { get; set; }

        public int 退票問題refundQaId { get; set; }
        public string 退票問題Question { get; set; }
        public string 退票問題Answer { get; set; }

        public int 優惠券couponQaId { get; set; }
        public string 優惠券問題Question { get; set; }
        public string 優惠券問題Answer { get; set; }

        public int 購物問題shopQaId { get; set; }
        public string 購物問題Question { get; set; }
        public string 購物問題Answer { get; set; }

        public int qtype { get; set; }

    }
    
}
