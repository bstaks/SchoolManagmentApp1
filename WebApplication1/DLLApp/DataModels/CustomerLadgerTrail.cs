//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DLLApp.DataModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class CustomerLadgerTrail
    {
        public int CustomerLadgerTrailId { get; set; }
        public int CustomerLadgerId { get; set; }
        public Nullable<decimal> CustomerLadgerTrailBalance { get; set; }
        public Nullable<System.DateTime> TransactionDate { get; set; }
    
        public virtual CustomerLadger CustomerLadger { get; set; }
    }
}
