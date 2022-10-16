using Microsoft.AspNetCore.Http;
using ServerMDA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ServerMDA.ViewModel
{
    public class CActorViewModel
    {
        private 演員總表actor _actor;
        public 演員總表actor actor
        {
            get { return _actor; }
            set { _actor = value; }
        }
        public CActorViewModel()
        {
            _actor = new 演員總表actor();  //每做一個就建一個
        }
        [DisplayName("演員編號")]
        public int 演員編號actorsId
        {
            get { return _actor.演員編號actorsId; }
            set { _actor.演員編號actorsId = value; }
        }
        [DisplayName("中文名")]
        public string 中文名字nameCht
        {
            get { return _actor.中文名字nameCht; }
            set { _actor.中文名字nameCht = value; }
        }
        [DisplayName("英文名")]
        public string 英文名字nameEng
        {
            get { return _actor.英文名字nameEng; }
            set { _actor.英文名字nameEng = value; }
        }
        [DisplayName("照片")]
        public string 演員照片image
        {
            get { return _actor.演員照片image; }
            set { _actor.演員照片image = value; }
        }

        public IFormFile photo { get; set; }
    }
}
