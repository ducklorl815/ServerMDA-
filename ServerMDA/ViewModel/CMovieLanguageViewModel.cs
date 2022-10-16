using ServerMDA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ServerMDA.ViewModel
{
    public class CMovieLanguageViewModel
    {
        private 電影語言movieLanguage _movieLanguage;
        public 電影語言movieLanguage movieLanguage
        {
            get { return _movieLanguage; }
            set { _movieLanguage = value; }
        }
        public CMovieLanguageViewModel()
        {
            _movieLanguage = new 電影語言movieLanguage();  //每做一個就建一個
        }

        [DisplayName("語言編號")]
        public int 語言編號languageId
        {
            get { return _movieLanguage.語言編號languageId; }
            set { _movieLanguage.語言編號languageId = value; }
        }
        [DisplayName("語言名稱")]
        public string 語言名稱languageName
        {
            get { return _movieLanguage.語言名稱languageName; }
            set { _movieLanguage.語言名稱languageName = value; }
        }
    }
}
