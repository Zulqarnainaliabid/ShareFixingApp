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
    
    public partial class LoanTaker
    {
        public LoanTaker()
        {
            this.LoanDetails = new HashSet<LoanDetail>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public System.DateTime DateAdded { get; set; }
        public bool IsDeleted { get; set; }
    
        public virtual ICollection<LoanDetail> LoanDetails { get; set; }
        public virtual LoanTaker LoanTaker1 { get; set; }
        public virtual LoanTaker LoanTaker2 { get; set; }
    }
}
