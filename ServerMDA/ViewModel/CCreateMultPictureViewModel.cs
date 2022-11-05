using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServerMDA.Models;
using System.ComponentModel;

namespace ServerMDA.ViewModel
{
    public class CCreateMultPictureViewModel
    {
        private 電影圖片總表movieImage _movieImage;
        public 電影圖片總表movieImage movieImage
        {
            get { return _movieImage; }
            set { _movieImage = value; }
        }
        public CCreateMultPictureViewModel()
        {
            _movieImage = new 電影圖片總表movieImage();  //每做一個就建一個
        }

        public int 圖片編號imageId
        {
            get { return _movieImage.圖片編號imageId; }
            set { _movieImage.圖片編號imageId = value; }
        }
        [DisplayName("電影海報")]
        public string 圖片image
        {
            get { return _movieImage.圖片image; }
            set { _movieImage.圖片image = value; }
        }
        [DisplayName("雲端圖片")]
        public string 圖片雲端imageImdb
        {
            get { return _movieImage.圖片雲端imageImdb; }
            set { _movieImage.圖片雲端imageImdb = value; }
        }
        [DisplayName("圖片類型")]
        public string 圖片類型imageType
        {
            get { return _movieImage.圖片類型imageType; }
            set { _movieImage.圖片類型imageType = value; }
        }
        [DisplayName("電影名稱")]
        public string 電影名稱movieName
        {
            get { return _movieImage.電影名稱movieName; }
            set { _movieImage.電影名稱movieName = value; }
        }
        [DisplayName("屏蔽")]
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
        public List<IFormFile> photo { get; set; }




        //電影中文名
        public List<string> titleChtList { get; set; }
        //圖片編號
        public List<int> titleImgList { get; set; }
        //圖片
        public List<string> titleImg { get; set; }


        public List<string> listImagetype { get; set; }
        public List<int> listinvisible { get; set; }
    }

}
