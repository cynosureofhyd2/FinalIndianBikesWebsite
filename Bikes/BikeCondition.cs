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
    
    public partial class BikeCondition
    {
        public int ConditionID { get; set; }
        public int BikeID { get; set; }
        public string Engine { get; set; }
        public string Battery { get; set; }
        public string Brakes { get; set; }
        public string Tyres { get; set; }
        public string Suspension { get; set; }
        public string Seat { get; set; }
    
        public virtual UsedBike UsedBike { get; set; }
    }
}
