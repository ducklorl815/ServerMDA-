using Microsoft.AspNetCore.Http;
using ServerMDA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [DisplayName("電影院編號")]
        public int 電影院編號theaterId
        {
            get { return _theater.電影院編號theaterId; }
            set { _theater.電影院編號theaterId = value; }
        }
        [DisplayName("電影院名稱")]
        public string 電影院名稱theaterName
        {
            get { return _theater.電影院名稱theaterName; }
            set { _theater.電影院名稱theaterName = value; }
        }
        [DisplayName("影城編號")]
        public int 影城編號mainTheaterId
        {
            get { return _theater.影城編號mainTheaterId; }
            set { _theater.影城編號mainTheaterId = value; }
        }
        [DisplayName("營業時間")]
        public string 營業時間businessHours
        {
            get { return _theater.營業時間businessHours; }
            set { _theater.營業時間businessHours = value; }
        }
        [DisplayName("電話")]
        public string 電話phone
        {
            get { return _theater.電話phone; }
            set { _theater.電話phone = value; }
        }
        [DisplayName("地址")]
        public string 地址address
        {
            get { return _theater.地址address; }
            set { _theater.地址address = value; }
        }
        [DisplayName("官方網站")]
        public string 官方網站url
        {
            get { return _theater.官方網站url; }
            set { _theater.官方網站url = value; }
        }
        [DisplayName("電影院照片")]
        public string 電影院照片image
        {
            get { return _theater.電影院照片image; }
            set { _theater.電影院照片image = value; }
        }
        //------------影廳
        public int 影廳編號cinemaId { get; set; }
        public string 影廳名稱cinemaName { get; set; }
        //public int 電影院編號theaterId { get; set; }
        public string 廳種名稱cinemaClsName { get; set; }
        public string 座位資訊seatInfo { get; set; }
        public string 影廳照片image { get; set; }
        public IFormFile photo { get; set; }
    }
}
