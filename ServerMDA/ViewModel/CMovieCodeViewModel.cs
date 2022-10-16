using ServerMDA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ServerMDA.ViewModel
{
    public class CMovieCodeViewModel
    {
        private 電影代碼movieCode _movieCode;
        public 電影代碼movieCode movieCode
        {
            get { return _movieCode; }
            set { _movieCode = value; }
        }
        public CMovieCodeViewModel()
        {
            _movieCode = new 電影代碼movieCode();  //每做一個就建一個
        }
        [DisplayName("電影代碼編號")]
        public int 電影代碼編號movieCodeId
        {
            get { return _movieCode.電影代碼編號movieCodeId; }
            set { _movieCode.電影代碼編號movieCodeId = value; }
        }
        [DisplayName("電影編號")]
        public int 電影編號movieId
        {
            get { return _movieCode.電影編號movieId; }
            set { _movieCode.電影編號movieId = value; }
        }
        [DisplayName("語言編號")]
        public int 語言編號languageId
        {
            get { return _movieCode.語言編號languageId; }
            set { _movieCode.語言編號languageId = value; }
        }
    }
}
