using Microsoft.AspNetCore.Http;
using ServerMDA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerMDA.ViewModel
{
    public class CCountrysViewModel
    {
        private 國家總表country _country;
        public 國家總表country country
        {
            get { return _country; }
            set { _country = value; }
        }
        public CCountrysViewModel()
        {
            _country = new 國家總表country();  //每做一個就建一個
        }
        public string 國家編號countryId
        {
            get { return _country.國家編號countryId; }
            set { _country.國家編號countryId = value; }
        }
        public string 國家名稱countryName
        {
            get { return _country.國家名稱countryName; }
            set { _country.國家名稱countryName = value; }
        }
        public string 國旗countryImage
        {
            get { return _country.國旗countryImage; }
            set { _country.國旗countryImage = value; }
        }

        //public virtual ICollection<電影產地movieOrigin> 電影產地movieOrigins { get; set; }
        public int 電影產地編號mcId { get; set; }
        public int 電影編號movieId { get; set; }
        //public string 國家編號countryId { get; set; }

        public IFormFile photo { get; set; }

    }
}
