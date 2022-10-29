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
        private 片種總表totalType _TypeListe;
        public 片種總表totalType TypeListe
        {
            get { return _TypeListe; }
            set { _TypeListe = value; }
        }
        public 電影片種movieType movieType
        {
            get { return _movieType; }
            set { _movieType = value; }
        }
        public CMovieTypeViewModel()
        {
            _movieType = new 電影片種movieType();  //每做一個就建一個
            _TypeListe = new 片種總表totalType();
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
            get { return _TypeListe.片種編號totalTypeId; }
            set { _TypeListe.片種編號totalTypeId = value; }
        }
        [DisplayName("片種")]
        public string 片種名稱totalTypeName
        {
            get { return _TypeListe.片種名稱totalTypeName; }
            set { _TypeListe.片種名稱totalTypeName = value; }
        }

        //電影movie
        //public int 電影編號movieId { get; set; }
        [DisplayName("中文標題")]
        public string 中文標題titleCht { get; set; }
        [DisplayName("英文標題")]
        public string 英文標題titleEng { get; set; }

        //public virtual 片種總表totalType 片種編號type { get; set; }
        //public virtual 電影movie 電影編號movie { get; set; }

        public List<string> titleCht { get; set; }
        public List<string> titleType { get; set; }

    }
}
