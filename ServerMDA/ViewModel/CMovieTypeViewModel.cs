using ServerMDA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ServerMDA.ViewModel
{
    public class CMovieTypeViewModel
    {
        private 電影片種movieType _movieType;
        public 電影片種movieType movieType
        {
            get { return _movieType; }
            set { _movieType = value; }
        }
        public CMovieTypeViewModel()
        {
            _movieType = new 電影片種movieType();  //每做一個就建一個
        }

        public int 電影片種編號mtId
        {
            get { return _movieType.電影片種編號mtId; }
            set { _movieType.電影片種編號mtId = value; }
        }
        public int 電影編號movieId
        {
            get { return _movieType.電影編號movieId; }
            set { _movieType.電影編號movieId = value; }
        }
        public int 片種編號typeId
        {
            get { return _movieType.片種編號typeId; }
            set { _movieType.片種編號typeId = value; }
        }
        //次片種總表type
        public int 片種編號totalTypeId { get; set; }
        public int 次片種編號typeId { get; set; }
        public string 次片種名稱typeName { get; set; }

        //電影movie
        //public int 電影編號movieId { get; set; }
        public string 中文標題titleCht { get; set; }
        public string 英文標題titleEng { get; set; }

    }
}
