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
    
    public partial class ShareHolder
    {
        public ShareHolder()
        {
            this.SHProfitDetails = new HashSet<SHProfitDetail>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Percentage { get; set; }
        public int Amount { get; set; }
        public System.DateTime DateAdded { get; set; }
        public Nullable<System.DateTime> DateUpdated { get; set; }
        public Nullable<int> LoanTakerId { get; set; }
    
        public virtual ICollection<SHProfitDetail> SHProfitDetails { get; set; }
    }
}
