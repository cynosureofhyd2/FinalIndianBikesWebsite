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
    
    public partial class State
    {
        public State()
        {
            this.Places = new HashSet<Place>();
        }
    
        public int StateID { get; set; }
        public string StateName { get; set; }
        public string Country { get; set; }
    
        public virtual ICollection<Place> Places { get; set; }
    }
}
