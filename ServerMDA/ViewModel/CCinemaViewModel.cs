using Microsoft.AspNetCore.Http;
using ServerMDA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerMDA.ViewModel
{
    public class CCinemaViewModel
    {
        private 影廳cinema _cinema;
        public 影廳cinema cinema
        {
            get { return _cinema; }
            set { _cinema = value; }
        }
        public CCinemaViewModel()
        {
            _cinema = new 影廳cinema();  //每做一個就建一個
        }
        public int 影廳編號cinemaId
        {
            get { return _cinema.影廳編號cinemaId; }
            set { _cinema.影廳編號cinemaId = value; }
        }

        public string 影廳名稱cinemaName
        {
            get { return _cinema.影廳名稱cinemaName; }
            set { _cinema.影廳名稱cinemaName = value; }
        }
        public int 電影院編號theaterId
        {
            get { return _cinema.電影院編號theaterId; }
            set { _cinema.電影院編號theaterId = value; }
        }
        public string 廳種名稱cinemaClsName
        {
            get { return _cinema.廳種名稱cinemaClsName; }
            set { _cinema.廳種名稱cinemaClsName = value; }
        }
        public string 座位資訊seatInfo
        {
            get { return _cinema.座位資訊seatInfo; }
            set { _cinema.座位資訊seatInfo = value; }
        }
        public string 影廳照片image
        {
            get { return _cinema.影廳照片image; }
            set { _cinema.影廳照片image = value; }
        }
        //----photo
        public IFormFile photo { get; set; }
        //----電影院theater
        //public int 電影院編號theaterId { get; set; }
        public string 電影院名稱theaterName { get; set; }
        public int 影城編號mainTheaterId { get; set; }
        public string 營業時間businessHours { get; set; }
        public string 電話phone { get; set; }
        public string 地址address { get; set; }
        public string 官方網站url { get; set; }
        public string 電影院照片image { get; set; }

        public List<string> ListTheater { get; set; }
        public List<string> ListClsName { get; set; }
        public List<string> ListSeat { get; set; }
    }
}
