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
    
    public partial class DailyStock
    {
        public int DailyStockID { get; set; }
        public int SaleID { get; set; }
        public int CategoryID { get; set; }
        public double Quantity { get; set; }
        public byte QtyType { get; set; }

        public virtual QuantityType QuantityType { get; set; }
        public virtual Sale Sale { get; set; }

    }
}
