//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class CoronaDetail
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public Nullable<System.DateTime> Vaccination_1 { get; set; }
        public Nullable<System.DateTime> Vaccination_2 { get; set; }
        public Nullable<System.DateTime> Vaccination_3 { get; set; }
        public Nullable<System.DateTime> Vaccination_4 { get; set; }
        public string Manufacturer { get; set; }
        public Nullable<System.DateTime> Positive_result { get; set; }
        public Nullable<System.DateTime> Recovery_date { get; set; }
    
        public virtual User User { get; set; }
    }
}