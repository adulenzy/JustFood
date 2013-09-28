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
    
    public partial class Notification
    {
        public Notification()
        {
            this.NotificationSeens = new HashSet<NotificationSeen>();
        }
    
        public long NotificationID { get; set; }
        public string Note { get; set; }
        public bool IsProductNeeded { get; set; }
        public bool IsAdminOnly { get; set; }
        public bool IsEmployeeOnly { get; set; }
        public bool IsForAll { get; set; }
        public bool IsUrgent { get; set; }
        public bool IsAutogenerated { get; set; }
        public Nullable<int> GeneratedBy { get; set; }
        public System.DateTime GeneratedDate { get; set; }
        public bool IsForSpecificUsersOnly { get; set; }
    
        public virtual User User { get; set; }
        public virtual ICollection<NotificationSeen> NotificationSeens { get; set; }
    }
}
