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
    
    public partial class Code
    {
        public int CodeID { get; set; }
        public bool IsUsed { get; set; }
        public System.Guid GuidCode { get; set; }
        public string Code1 { get; set; }
        public bool IsOwner { get; set; }
        public bool IsAccessToAdmin { get; set; }
        public bool IsEmployee { get; set; }
        public Nullable<decimal> Salary { get; set; }
        public Nullable<decimal> Percentage { get; set; }
    }
}
