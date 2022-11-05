using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using ServerMDA.Models;

namespace ServerMDA.ViewModel
{
    public class COneDragonViewModelcs
    {
        public int Series_ID { get; set; }
        public string Title_Chi { get; set; }
        public string Title_Eng { get; set; }
        public DateTime Release_Date { get; set; }
        public int runtime { get; set; }
        public int Rate_ID { get; set; }
        public double Box { get; set; }
        public string Plot { get; set; }
        public string TrailerUrl { get; set; }


        public List<IFormFile> photos { get; set; }
        public List<int> directors { get; set; }
        public List<int> actors { get; set; }
    }
}
