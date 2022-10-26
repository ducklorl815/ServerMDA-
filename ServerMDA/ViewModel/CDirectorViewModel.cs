using Microsoft.AspNetCore.Http;
using ServerMDA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ServerMDA.ViewModel
{
    public class CDirectorViewModel
    {
        private 導演總表director _director;
        public 導演總表director director
        {
            get { return _director; }
            set { _director = value; }
        }
        public CDirectorViewModel()
        {
            _director = new 導演總表director();  //每做一個就建一個
        }
        [DisplayName("導演編號")]
        public int 導演編號directorId
        {
            get { return _director.導演編號directorId; }
            set { _director.導演編號directorId = value; }
        }
        [DisplayName("中文名")]
        public string 中文名字nameCht
        {
            get { return _director.導演中文名字nameCht; }
            set { _director.導演中文名字nameCht = value; }
        }
        [DisplayName("英文名")]
        public string 英文名字nameEng
        {
            get { return _director.導演英文名字nameEng; }
            set { _director.導演英文名字nameEng = value; }
        }
        [DisplayName("照片")]
        public string 導演照片image
        {
            get { return _director.導演照片image; }
            set { _director.導演照片image = value; }
        }
        public IFormFile photo { get; set; }
    }
}
