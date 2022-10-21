using Microsoft.AspNetCore.Http;
using ServerMDA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerMDA.ViewModel
{
    public class CMovieImageViewModel
    {
        private 電影圖片總表movieImage _movieImage;
        public 電影圖片總表movieImage movieImage
        {
            get { return _movieImage; }
            set { _movieImage = value; }
        }
        public CMovieImageViewModel()
        {
            _movieImage = new 電影圖片總表movieImage();  //每做一個就建一個
        }
        public int 圖片編號imageId
        {
            get { return _movieImage.圖片編號imageId; }
            set { _movieImage.圖片編號imageId = value; }
        }
        public string 圖片image
        {
            get { return _movieImage.圖片image; }
            set { _movieImage.圖片image = value; }
        }
        public string 圖片雲端imageImdb
        {
            get { return _movieImage.圖片雲端imageImdb; }
            set { _movieImage.圖片雲端imageImdb = value; }
        }
        public string 圖片類型imageType
        {
            get { return _movieImage.圖片類型imageType; }
            set { _movieImage.圖片類型imageType = value; }
        }
        public string 電影名稱movieName
        {
            get { return _movieImage.電影名稱movieName; }
            set { _movieImage.電影名稱movieName = value; }
        }
        public int? 屏蔽invisible
        {
            get { return _movieImage.屏蔽invisible; }
            set { _movieImage.屏蔽invisible = value; }
        }
        //---電影圖片movieIimagesList--
        public int 電影圖片編號miId { get; set; }
        public int 電影編號movieId { get; set; }

        //電影movie
        //public int 電影編號movieId { get; set; }
        public string 中文標題titleCht { get; set; }
        //---photo--
        //public List<IFormFile> photo { get; set; }
        public IFormFile photo { get; set; }

        //option
        //電影中文名 (目標為option內的資料內容)
        public List<string> listImagetype { get; set; }
        public List<int> listinvisible { get; set; }
    }
}
