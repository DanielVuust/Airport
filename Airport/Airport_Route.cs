//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Airport
{
    using System;
    using System.Collections.Generic;
    
    public partial class Airport_Route
    {
        public string Airport_StartIATA { get; set; }
        public string Airport_EndIATA { get; set; }
        public int Route_RouteId { get; set; }
    
        public virtual AirPort AirPort { get; set; }
        public virtual AirPort AirPort1 { get; set; }
        public virtual Route Route { get; set; }
    }
}
