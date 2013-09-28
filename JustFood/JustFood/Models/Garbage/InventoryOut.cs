//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JustFood.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class InventoryOut
    {
        public long InventoryOutID { get; set; }
        public int CategoryID { get; set; }
        public decimal Quantity { get; set; }
        public System.DateTime Dated { get; set; }
        public bool IsWaste { get; set; }
        public bool IsLoss { get; set; }
        public string Note { get; set; }
        public bool IsChanged { get; set; }
        public int UserID { get; set; }
        public double SoldPrice { get; set; }
        public bool IsIncurBySelling { get; set; }
        public byte QtyType { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual QuantityType QuantityType { get; set; }
    }
}
