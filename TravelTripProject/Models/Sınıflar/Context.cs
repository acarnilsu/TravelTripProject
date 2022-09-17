using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TravelTripProject.Models.Sınıflar
{
    public class Context: DbContext
    {
        public DbSet<Admin>Admins { get; set; }
        public DbSet<AdresBlog> AddressBlogs { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Hakkımızda> AboutUs { get; set; }
        public DbSet<Iletişim> Contacts { get; set; }
        public DbSet<Yorumlar> Comments { get; set; }
        public object Hakkımızda { get; internal set; }
    }
}