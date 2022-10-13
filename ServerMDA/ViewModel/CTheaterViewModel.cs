using Microsoft.AspNetCore.Http;
using ServerMDA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerMDA.ViewModel
{
    public class CTheaterViewModel
    {
        private 電影院theater _theater;
        public 電影院theater theater
        {
            get { return _theater; }
            set { _theater = value; }
        }
        public CTheaterViewModel()
        {
            _theater = new 電影院theater();  //每做一個就建一個
        }
        public int 電影院編號theaterId
        {
            get { return _theater.電影院編號theaterId; }
            set { _theater.電影院編號theaterId = value; }
        }
        public string 電影院名稱theaterName
        {
            get { return _theater.電影院名稱theaterName; }
            set { _theater.電影院名稱theaterName = value; }
        }
        public int 影城編號mainTheaterId
        {
            get { return _theater.影城編號mainTheaterId; }
            set { _theater.影城編號mainTheaterId = value; }
        }
        public string 營業時間businessHours
        {
            get { return _theater.營業時間businessHours; }
            set { _theater.營業時間businessHours = value; }
        }
        public string 電話phone
        {
            get { return _theater.電話phone; }
            set { _theater.電話phone = value; }
        }
        public string 地址address
        {
            get { return _theater.地址address; }
            set { _theater.地址address = value; }
        }
        public string 官方網站url
        {
            get { return _theater.官方網站url; }
            set { _theater.官方網站url = value; }
        }
        public string 電影院照片imagepath
        {
            get { return _theater.電影院照片imagepath; }
            set { _theater.電影院照片imagepath = value; }
        }

        public IFormFile photo { get; set; }
    }
}
