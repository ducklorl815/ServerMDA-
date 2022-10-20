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
        public int 屏蔽invisible
        {
            get { return _movieImage.屏蔽invisible; }
            set { _movieImage.屏蔽invisible = value; }
        }
        public string 圖片imageType
        {
            get { return _movieImage.圖片imageType; }
            set { _movieImage.圖片imageType = value; }
        }

        //---電影圖片movieIimagesList--
        public int 電影圖片編號miId { get; set; }
        public int 電影編號movieId { get; set; }

        //---電影圖片movieIimagesList--

        public IFormFile photo { get; set; }
        //public List<IFormFile> photo { get; set; }
    }
}
