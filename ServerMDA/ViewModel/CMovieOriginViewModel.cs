using ServerMDA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerMDA.ViewModel
{
    public class CMovieOriginViewModel
    {
        private 電影產地movieOrigin _Origin;
        public 電影產地movieOrigin Origin
        {
            get { return _Origin; }
            set { _Origin = value; }
        }
        public CMovieOriginViewModel()
        {
            _Origin = new 電影產地movieOrigin();  //每做一個就建一個
        }
        public int 電影產地編號mcId
        {
            get { return _Origin.電影產地編號mcId; }
            set { _Origin.電影產地編號mcId = value; }
        }
        public int 電影編號movieId
        {
            get { return _Origin.電影編號movieId; }
            set { _Origin.電影編號movieId = value; }
        }
        public string 國家編號countryId
        {
            get { return _Origin.國家編號countryId; }
            set { _Origin.國家編號countryId = value; }
        }

        //國家總表country
        //public string 國家編號countryId { get; set; }
        public string 國家名稱countryName { get; set; }
        public byte[] 國旗countryImage { get; set; }

        //電影movie
        //public int 電影編號movieId { get; set; }
        public string 中文標題titleCht { get; set; }
    }
}
