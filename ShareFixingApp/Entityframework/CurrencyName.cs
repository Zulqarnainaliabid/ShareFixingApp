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
    
    public partial class CurrencyName
    {
        public CurrencyName()
        {
            this.FCAverageRates = new HashSet<FCAverageRate>();
            this.SalePurchases = new HashSet<SalePurchase>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public byte[] Flag { get; set; }
        public System.DateTime DateAdded { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<double> UperRange { get; set; }
        public Nullable<double> LowerRange { get; set; }
    
        public virtual ICollection<FCAverageRate> FCAverageRates { get; set; }
        public virtual ICollection<SalePurchase> SalePurchases { get; set; }
    }
}