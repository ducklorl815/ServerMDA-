﻿using ServerMDA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ServerMDA.ViewModel
{
    public class CMovieViewModel
    {
        private 電影movie _movie;
        public 電影movie movie
        {
            get { return _movie; }
            set { _movie = value; }
        }
        public CMovieViewModel()
        {
            _movie = new 電影movie();  //每做一個就建一個
            _cast = new 電影主演cast();  //每做一個就建一個
            _director = new 導演總表director();  //每做一個就建一個
        }
        [DisplayName("電影編號")]
        public int 電影編號movieId
        {
            get { return _movie.電影編號movieId; }
            set { _movie.電影編號movieId = value; }
        }
        [DisplayName("系列編號")]
        public int? 系列編號seriesId
        {
            get { return _movie.系列編號seriesId; }
            set { _movie.系列編號seriesId = value; }
        }
        [DisplayName("中文標題")]
        public string 中文標題titleCht
        {
            get { return _movie.中文標題titleCht; }
            set { _movie.中文標題titleCht = value; }
        }
        [DisplayName("英文標題")]
        public string 英文標題titleEng
        {
            get { return _movie.英文標題titleEng; }
            set { _movie.英文標題titleEng = value; }
        }
        [DisplayName("上映年")]
        public int 上映年份releaseYear
        {
            get { return _movie.上映年份releaseYear; }
            set { _movie.上映年份releaseYear = value; }
        }
        [DisplayName("上映日期")]
        public string 上映日期releaseDate
        {
            get { return _movie.上映日期releaseDate; }
            set { _movie.上映日期releaseDate = value; }
        }
        [DisplayName("片長")]
        public int? 片長runtime
        {
            get { return _movie.片長runtime; }
            set { _movie.片長runtime = value; }
        }
        [DisplayName("電影分級")]
        public int 電影分級編號ratingId
        {
            get { return _movie.電影分級編號ratingId; }
            set { _movie.電影分級編號ratingId = value; }
        }

        [DisplayName("票房")]
        public string 票房boxOffice
        {
            get { return _movie.票房boxOffice; }
            set { _movie.票房boxOffice = value; }
        }
        [DisplayName("劇情大綱")]
        public string 劇情大綱plot
        {
            get { return _movie.劇情大綱plot; }
            set { _movie.劇情大綱plot = value; }
        }
        [DisplayName("評分")]
        public decimal? 評分rate
        {
            get { return _movie.評分rate; }
            set { _movie.評分rate = value; }
        }
        [DisplayName("期待度")]
        public decimal? 期待度anticipation
        {
            get { return _movie.期待度anticipation; }
            set { _movie.期待度anticipation = value; }
        }
        //=======================================================
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

        //=======================================================
        private 導演總表director _director;
        public 導演總表director director
        {
            get { return _director; }
            set { _director = value; }
        }
        [DisplayName("導演編號")]
        public int 導演編號directorId
        {
            get { return _director.導演編號directorId; }
            set { _director.導演編號directorId = value; }
        }
        [DisplayName("中文名")]
        public string 中文名字nameCht
        {
            get { return _director.中文名字nameCht; }
            set { _director.中文名字nameCht = value; }
        }
        [DisplayName("英文名")]
        public string 英文名字nameEng
        {
            get { return _director.英文名字nameEng; }
            set { _director.英文名字nameEng = value; }
        }
        [DisplayName("照片")]
        public string 導演照片image
        {
            get { return _director.導演照片image; }
            set { _director.導演照片image = value; }
        }
        //=======================================================
        [DisplayName("分級編號")]
        public int 分級編號ratingId { get; set; }
        [DisplayName("分級級數")]
        public string 分級級數ratingLevel { get; set; }
        [DisplayName("分級說明")]
        public string 分級說明ratingIllustrate { get;set;}

        [DisplayName("系列名稱")]
        public string 系列名稱seriesName { get; set; }

        [DisplayName("分級圖片")]
        public byte[] 分級圖片ratingImage{ get; set; }
    }
}
