using Microsoft.AspNetCore.Http;
using ServerMDA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ServerMDA.ViewModel
{
    public class CCommentImagesListViewModel
    {
        private 評論圖片明細commentImagesList _ImagesList;
        public 評論圖片明細commentImagesList ImagesList
        {
            get { return _ImagesList; }
            set { _ImagesList = value; }
        }
        public CCommentImagesListViewModel()
        {
            _ImagesList = new 評論圖片明細commentImagesList();  //每做一個就建一個
        }
        [DisplayName("評論圖片編號")]
        public int 評論圖片編號ccId
        {
            get { return _ImagesList.評論圖片編號ccId; }
            set { _ImagesList.評論圖片編號ccId = value; }
        }
        [DisplayName("評論圖庫編號")]
        public int 評論圖庫編號commentImageId
        {
            get { return _ImagesList.評論圖庫編號commentImageId; }
            set { _ImagesList.評論圖庫編號commentImageId = value; }
        }
        [DisplayName("評論編號")]
        public int 評論編號commentId
        {
            get { return _ImagesList.評論編號commentId; }
            set { _ImagesList.評論編號commentId = value; }
        }
        public IFormFile photo { get; set; }
        //public virtual 評論圖片總表commentImage 評論圖庫編號commentImage { get; set; }
        //public int 評論圖庫編號commentImageId { get; set; }
        [DisplayName("圖片")]
        public string 圖片image { get; set; }
        public int 屏蔽invisible { get; set; }
        //public virtual 電影評論movieComment 評論編號comment { get; set; }
        //public int 評論編號commentId { get; set; }
        public int 會員編號memberId { get; set; }
        public int 電影編號movieId { get; set; }
        public decimal? 評分rate { get; set; }
        public decimal? 期待度anticipation { get; set; }
        [DisplayName("評論標題")]
        public string 評論標題commentTitle { get; set; }
        public string 評論內容comments { get; set; }
        public DateTime 發佈時間commentTime { get; set; }
        public DateTime? 觀影日期viewingTime { get; set; }
        public string 觀影方式source { get; set; }
        public int? 公開等級編號publicId { get; set; }
        public bool? 是否開放討論串oxFloor { get; set; }
        //public int 屏蔽invisible { get; set; }
        public List<string> titleComm { get; set; }
    }
}
