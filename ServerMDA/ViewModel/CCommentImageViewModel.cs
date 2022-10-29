using Microsoft.AspNetCore.Http;
using ServerMDA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ServerMDA.ViewModel
{
    public class CCommentImageViewModel
    {
        private 評論圖片總表commentImage _commentImage;
        public 評論圖片總表commentImage commentImage
        {
            get { return _commentImage; }
            set { _commentImage = value; }
        }
        public CCommentImageViewModel()
        {
            _commentImage = new 評論圖片總表commentImage();  //每做一個就建一個
        }
        [DisplayName("評論圖庫編號")]
        public int 評論圖庫編號commentImageId
        {
            get { return _commentImage.評論圖庫編號commentImageId; }
            set { _commentImage.評論圖庫編號commentImageId = value; }
        }
        [DisplayName("圖片")]
        public string 圖片image
        {
            get { return _commentImage.圖片image; }
            set { _commentImage.圖片image = value; }
        }
        [DisplayName("屏蔽")]
        public int 屏蔽invisible
        {
            get { return _commentImage.屏蔽invisible; }
            set { _commentImage.屏蔽invisible = value; }
        }

        public IFormFile photo { get; set; }
        public int 評論圖片編號ccId { get; set; }
        //public int 評論圖庫編號commentImageId { get; set; }
        public int 評論編號commentId { get; set; }
        //public virtual ICollection<評論圖片明細commentImagesList> 評論圖片明細commentImagesLists { get; set; }
    }
}
