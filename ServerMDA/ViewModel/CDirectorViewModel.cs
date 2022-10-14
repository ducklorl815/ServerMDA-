using Microsoft.AspNetCore.Http;
using ServerMDA.Models;
using System;
using System.Collections.Generic;
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
        public int 導演編號directorId
        {
            get { return _director.導演編號directorId; }
            set { _director.導演編號directorId = value; }
        }
        public string 中文名字nameCht
        {
            get { return _director.中文名字nameCht; }
            set { _director.中文名字nameCht = value; }
        }
        public string 英文名字nameEng
        {
            get { return _director.英文名字nameEng; }
            set { _director.英文名字nameEng = value; }
        }
        public string 導演照片image
        {
            get { return _director.導演照片image; }
            set { _director.導演照片image = value; }
        }
        public IFormFile photo { get; set; }
    }
}
