//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bikes
{
    using System;
    using System.Collections.Generic;
    
    public partial class UsedBike
    {
        public UsedBike()
        {
            this.BikeConditions = new HashSet<BikeCondition>();
        }
    
        public int ID { get; set; }
        public int BrandID { get; set; }
        public Nullable<int> ModelID { get; set; }
        public Nullable<int> Year { get; set; }
        public Nullable<int> Month { get; set; }
        public Nullable<double> Price { get; set; }
        public string Text { get; set; }
        public int RegistrationId { get; set; }
        public Nullable<int> Kilometers { get; set; }
        public string Fuel { get; set; }
        public string Color { get; set; }
        public string ImageLoc { get; set; }
    
        public virtual ICollection<BikeCondition> BikeConditions { get; set; }
        public virtual UsedBike UsedBike1 { get; set; }
        public virtual UsedBike UsedBike2 { get; set; }
    }
}
