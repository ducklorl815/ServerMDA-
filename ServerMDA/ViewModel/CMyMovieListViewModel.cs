using ServerMDA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ServerMDA.ViewModel
{ 
    public class CMyMovieListViewModel
    {
        private 我的片單myMovieList _myMovieList;
        public 我的片單myMovieList myMovieList
        {
            get { return _myMovieList; }
            set { _myMovieList = value; }
        }
        public CMyMovieListViewModel()
        {
            _myMovieList = new 我的片單myMovieList();  //每做一個就建一個
        }

        [DisplayName("我的片單")]
        public int 我的片單myMovieListId
        {
            get { return _myMovieList.我的片單myMovieListId; }
            set { _myMovieList.我的片單myMovieListId = value; }
        }
        [DisplayName("片單總表編號")]
        public int 片單總表編號movieListId
        {
            get { return _myMovieList.片單總表編號movieListId; }
            set { _myMovieList.片單總表編號movieListId = value; }
        }
        [DisplayName("會員編號")]
        public int 會員編號memberId
        {
            get { return _myMovieList.會員編號memberId; }
            set { _myMovieList.會員編號memberId = value; }
        }
        [DisplayName("電影編號")]
        public int 電影編號movieId
        {
            get { return _myMovieList.電影編號movieId; }
            set { _myMovieList.電影編號movieId = value; }
        }

        //public virtual 會員member 會員編號member { get; set; }
        [DisplayName("姓")]
        public string 姓氏lName { get; set; }
        [DisplayName("名")]
        public string 名字fName { get; set; }
        [DisplayName("暱稱")]
        public string 暱稱nickName { get; set; }
        [DisplayName("會員電話")]
        public string 會員電話cellphone { get; set; }


        //public virtual 片單總表movieList 片單總表編號movieList { get; set; }
        //public int 片單總表編號movieListId { get; set; }
        [DisplayName("片單總表名稱")]
        public string 片單總表名稱listName { get; set; }
        //public int 會員編號memberId { get; set; }

        //public virtual 電影movie 電影編號movie { get; set; }
        [DisplayName("中文名")]
        public string 中文標題titleCht { get; set; }
        [DisplayName("英文名")]
        public string 英文標題titleEng { get; set; }


        public List<string> titleCht中文標題 { get; set; }
    }
}
