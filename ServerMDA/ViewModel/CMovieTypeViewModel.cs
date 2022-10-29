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
        private 片單總表movieList _movieListe;
        public 片單總表movieList movieListe
        {
            get { return _movieListe; }
            set { _movieListe = value; }
        }
        public 電影片種movieType movieType
        {
            get { return _movieType; }
            set { _movieType = value; }
        }
        public CMovieTypeViewModel()
        {
            _movieType = new 電影片種movieType();  //每做一個就建一個
            _movieListe = new 片單總表movieList();
        }
        [DisplayName("電影片種編號")]
        public int 電影片種編號mtId
        {
            get { return _movieType.電影片種編號mtId; }
            set { _movieType.電影片種編號mtId = value; }
        }
        [DisplayName("電影編號")]
        public int 電影編號movieId
        {
            get { return _movieType.電影編號movieId; }
            set { _movieType.電影編號movieId = value; }
        }
        [DisplayName("片種編號")]
        public int 片種編號typeId
        {
            get { return _movieType.片種編號typeId; }
            set { _movieType.片種編號typeId = value; }
        }
        //public virtual 片種總表totalType 片種編號type { get; set; }
        [DisplayName("片種編號")]
        public int 片種編號totalTypeId
        {
            get { return _movieListe.片單總表編號movieListId; }
            set { _movieListe.片單總表編號movieListId = value; }
        }
        [DisplayName("片種")]
        public string 片種名稱totalTypeName
        {
            get { return _movieListe.片單總表名稱listName; }
            set { _movieListe.片單總表名稱listName = value; }
        }

        //電影movie
        //public int 電影編號movieId { get; set; }
        [DisplayName("中文標題")]
        public string 中文標題titleCht { get; set; }
        [DisplayName("英文標題")]
        public string 英文標題titleEng { get; set; }

        public virtual 片種總表totalType 片種編號type { get; set; }
        public virtual 電影movie 電影編號movie { get; set; }

        public List<string> titleCht { get; set; }
        public List<string> titleType { get; set; }

    }
}
