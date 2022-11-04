using ServerMDA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerMDA.ViewModel.WenViewModel
{

    public class CRList
    {
        public List<明細> 購買的明細表;
        public int 商品編號productId { get; set; }
        public string 商品名稱productName { get; set; }
        public 商品資料product product { get; set; }
    }
    public class 明細
    {
        public int 商品編號productId { get; set; }
        public string 商品名稱productName { get; set; }
        public decimal 商品價格productPrice { get; set; }
        public int 電影院編號theaterId { get; set; }
        public string 電影院名稱theaterName { get; set; }
        public string 商品圖片image { get; set; }
        public string 商品圖片路徑imagePath { get; set; }
        public string 商品介紹introduce { get; set; }
        public string 類別category { get; set; }
        public int 購買商品明細編號receiptId { get; set; }
        public int 訂單編號orderId { get; set; }
        public int 商品數量qty { get; set; }
        public 訂單總表order 訂單編號order { get; set; }
        public 商品資料product product { get; set; }
        public 電影院theater theater { get; set; }

    }

}

