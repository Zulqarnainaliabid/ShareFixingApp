//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShareFixingApp.Entityframework
{
    using System;
    using System.Collections.Generic;
    
    public partial class FCAverageRate
    {
        public int Id { get; set; }
        public int CurrencyNameId { get; set; }
        public Nullable<double> Amount { get; set; }
        public double Average { get; set; }
        public System.DateTime DateAdded { get; set; }
        public Nullable<System.DateTime> DateUpdated { get; set; }
    
        public virtual CurrencyName CurrencyName { get; set; }
    }
}