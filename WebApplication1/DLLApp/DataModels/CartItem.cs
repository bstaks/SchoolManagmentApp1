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
    
    public partial class CartItem
    {
        public int CartItemId { get; set; }
        public int ProductItemId { get; set; }
        public System.Guid BrowwerId { get; set; }
        public bool IsAnomoyus { get; set; }
        public System.DateTime CartDate { get; set; }
    
        public virtual Porduct Porduct { get; set; }
    }
}
