using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models.Sınıflar
{
    public class AnaSayfa
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Comment { get; set; }
    }
}