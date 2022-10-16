using Microsoft.AspNetCore.Http;
using ServerMDA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ServerMDA.ViewModel
{
    public class CMovieRatingViewModel
    {
        private 電影分級movieRating _Rating;
        public 電影分級movieRating Rating
        {
            get { return _Rating; }
            set { _Rating = value; }
        }
        public CMovieRatingViewModel()
        {
            _Rating = new 電影分級movieRating();  //每做一個就建一個
        }
        [DisplayName("分級編號")]
        public int 分級編號ratingId
        {
            get { return _Rating.分級編號ratingId; }
            set { _Rating.分級編號ratingId = value; }
        }
        [DisplayName("分級級數")]
        public string 分級級數ratingLevel
        {
            get { return _Rating.分級級數ratingLevel; }
            set { _Rating.分級級數ratingLevel = value; }
        }
        [DisplayName("分級說明")]
        public string 分級說明ratingIllustrate
        {
            get { return _Rating.分級說明ratingIllustrate; }
            set { _Rating.分級說明ratingIllustrate = value; }
        }
        [DisplayName("分級圖片")]
        public byte[] 分級圖片ratingImage
        {
            get { return _Rating.分級圖片ratingImage; }
            set { _Rating.分級圖片ratingImage = value; }
        }
        public IFormFile photo { get; set; }
    }
}
