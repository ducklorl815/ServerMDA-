using Microsoft.AspNetCore.Http;
using ServerMDA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ServerMDA.ViewModel
{
    public class CCastViewModel
    {
        public CCastViewModel()
        {
            _cast = new 電影主演cast();  //每做一個就建一個
        }

        private 電影主演cast _cast;
        public 電影主演cast cast
        {
            get { return _cast; }
            set { _cast = value; }
        }

        [DisplayName("主演編號")]
        public int 主演編號maId
        {
            get { return _cast.主演編號maId; }
            set { _cast.主演編號maId = value; }
        }
        [DisplayName("電影編號")]
        public int 電影編號movieId
        {
            get { return _cast.電影編號movieId; }
            set { _cast.電影編號movieId = value; }
        }
        [DisplayName("演員編號")]
        public int 演員編號actorId
        {
            get { return _cast.演員編號actorId; }
            set { _cast.演員編號actorId = value; }
        }
        [DisplayName("角色名字")]
        public string 角色名字characterName
        {
            get { return _cast.角色名字characterName; }
            set { _cast.角色名字characterName = value; }
        }
        [DisplayName("角色說明")]
        public string 角色說明characterIllustrate
        {
            get { return _cast.角色說明characterIllustrate; }
            set { _cast.角色說明characterIllustrate = value; }
        }
        //演員總表actor
        public int 演員編號actorsId { get; set; }
        [DisplayName("中文名")]
        public string 中文名字nameCht { get; set; }
        [DisplayName("英文名")]
        public string 英文名字nameEng { get; set; }
        [DisplayName("演員照片")]
        public string 演員照片image { get; set; }

        //電影movie
        public string 中文標題titleCht { get; set; }
        //public virtual 演員總表actor 演員編號actor { get; set; }
        //public virtual 電影movie 電影編號movie { get; set; }

        //圖片
        public IFormFile photo { get; set; }

        //電影中文名 (目標為option內的資料內容)
        public List<string> titleNameList { get; set; }

  
    }
}
