using Microsoft.AspNetCore.Http;
using ServerMDA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerMDA.ViewModel
{
    public class CMovieImagesListViewModel
    {
        private 電影圖片movieIimagesList _movieIimagesList;
        public 電影圖片movieIimagesList movieIimagesList
        {
            get { return _movieIimagesList; }
            set { _movieIimagesList = value; }
        }
        public CMovieImagesListViewModel()
        {
            _movieIimagesList = new 電影圖片movieIimagesList();  //每做一個就建一個
        }
        public int 電影圖片編號miId
        {
            get { return _movieIimagesList.電影圖片編號miId; }
            set { _movieIimagesList.電影圖片編號miId = value; }
        }
        public int 電影編號movieId
        {
            get { return _movieIimagesList.電影編號movieId; }
            set { _movieIimagesList.電影編號movieId = value; }
        }
        public int 圖片編號imageId
        {
            get { return _movieIimagesList.圖片編號imageId; }
            set { _movieIimagesList.圖片編號imageId = value; }
        }




        //電影中文名
        public List<string> titleChtList { get; set; }
        //圖片編號
        public List<int> titleImgList { get; set; }
        //圖片
        public List<string> titleImg { get; set; }
        //電影圖片總表movieImage
        //public int 圖片編號imageId { get; set; }
        public string 圖片image { get; set; }
        public string 圖片雲端imageImdb { get; set; }
        public string 圖片類型imageType { get; set; }
        public string 電影名稱movieName { get; set; }
        public int? 屏蔽invisible { get; set; }

        //電影movie
        public int? 系列編號seriesId { get; set; }
        public string 中文標題titleCht { get; set; }
        public string 英文標題titleEng { get; set; }
        public int 上映年份releaseYear { get; set; }
        public string 上映日期releaseDate { get; set; }
        public int? 片長runtime { get; set; }
        public int 電影分級編號ratingId { get; set; }
        public decimal? 評分rate { get; set; }
        public decimal? 期待度anticipation { get; set; }
        public string 票房boxOffice { get; set; }
        public string 劇情大綱plot { get; set; }
        public string 預告片trailer { get; set; }

        //photo
        public IFormFile photo { get; set; }
    }
}
