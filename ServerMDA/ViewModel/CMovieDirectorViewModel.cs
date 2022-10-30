using Microsoft.AspNetCore.Http;
using ServerMDA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ServerMDA.ViewModel
{
    public class CMovieDirectorViewModel
    {
        public CMovieDirectorViewModel()
        {
            _director = new 電影導演movieDirector(); //每做一個就建一個
        }

        private 電影導演movieDirector _director;
        public 電影導演movieDirector director
        {
            get { return _director; }
            set { _director = value; }
        }

        //電影導演movieDirector 
        [DisplayName("電影導演編號")]
        public int 電影導演編號mdId
        {
            get { return _director.電影導演編號mdId; }
            set { _director.電影導演編號mdId = value; }
        }
        [DisplayName("電影編號")]
        public int 電影編號movieId
        {
            get { return _director.電影編號movieId; }
            set { _director.電影編號movieId = value; }
        }
        [DisplayName("導演編號")]
        public int 導演編號directorId
        {
            get { return _director.導演編號directorId; }
            set { _director.導演編號directorId = value; }
        }

        //public virtual 導演總表director 導演編號director { get; set; }

        //public int 導演編號directorId { get; set; }
        [DisplayName("中文名")]
        public string 導演中文名字nameCht { get; set; }
        [DisplayName("英文名")]
        public string 導演英文名字nameEng { get; set; }
        [DisplayName("導演照片")]
        public string 導演照片image { get; set; }


        //電影movie
        [DisplayName("中文標題")]
        public string 中文標題titleCht { get; set; }
        //public virtual 電影movie 電影編號movie { get; set; }

        //圖片
        public IFormFile photo { get; set; }

        //電影中文名 (目標為option內的資料內容)
        public List<string> titleNameList { get; set; }

    }
}
