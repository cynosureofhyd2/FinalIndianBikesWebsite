using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Bikes.ViewModels
{
    public class SellBikeViewModel
        {
    //    public UsedBike UsedBike { get; set; }
    //    public BikeModel Model { get; set; }
    //    public BikeBrand Brand { get; set; }
    //    public User UserDetails { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<string> State { get; set; }
        public List<string> City { get; set; }
        public string Place { get; set; }
        public int Phone { get; set; }
        [DisplayName("Brand")]
        public string BrandName { get; set; }
        [DisplayName("Model")]
        public string BikeModel { get; set; }
        [DisplayName("Version")]
        public string Variant { get; set; }
        [DisplayName("Year")]
        public int YearMade { get; set; }
        [DisplayName("Month")]
        public int MonthMade { get; set; }
        public List<int> ExpectedPriceRange { get; set; }
        [DisplayName("Kilometers Driven")]
        public int KMDriven { get; set; }
        [DisplayName("Color")]
        public string Color { get; set; } 
    }
}