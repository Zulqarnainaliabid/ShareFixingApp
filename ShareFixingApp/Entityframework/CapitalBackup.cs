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
    
    public partial class CapitalBackup
    {
        public int Id { get; set; }
        public double TodayAmount { get; set; }
        public double Capital { get; set; }
        public System.DateTime DateAdded { get; set; }
        public bool IsDeleted { get; set; }
        public double CashInHand { get; set; }
        public double Difference { get; set; }
    }
}
