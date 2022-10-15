using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable

namespace ServerMDA.Models
{
    public partial class 電影分級movieRating
    {
        public 電影分級movieRating()
        {
            電影movies = new HashSet<電影movie>();
        }
        [DisplayName("分級編號")]
        public int 分級編號ratingId { get; set; }
        [DisplayName("分級級數")]
        public string 分級級數ratingLevel { get; set; }
        [DisplayName("分級說明")]
        public string 分級說明ratingIllustrate { get; set; }
        [DisplayName("圖片")]
        public byte[] 分級圖片ratingImage { get; set; }

        public virtual ICollection<電影movie> 電影movies { get; set; }
    }
}
