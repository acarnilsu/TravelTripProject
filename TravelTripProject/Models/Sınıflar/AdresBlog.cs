using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models.Sınıflar
{
    public class AdresBlog
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Comment { get; set; }
        public string Address { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public string Location { get; set; }

    }
}