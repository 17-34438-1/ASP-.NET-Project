//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System.ComponentModel.DataAnnotations;
namespace JustEat.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CustomerNotification
    {
        public int Id { get; set; }
        public string Notice { get; set; }
        public int CustomerId { get; set; }
        public System.DateTime DateTime { get; set; }
        public Nullable<int> OrderId { get; set; }
    
        public virtual CustomerNotification CustomerNotifications1 { get; set; }
        public virtual CustomerNotification CustomerNotification1 { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Order Order { get; set; }
    }
}
