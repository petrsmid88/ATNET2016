//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceBus
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public int Id { get; set; }
        public System.DateTime OrderDate { get; set; }
        public System.DateTime DeliveryDate { get; set; }
        public int AddressId { get; set; }
        public int BillingInformationId { get; set; }
        public int UserId { get; set; }
        public int Status { get; set; }
    
        public virtual Address Address { get; set; }
        public virtual BillingInformation BillingInformation { get; set; }
        public virtual Basket Basket { get; set; }
        public virtual User User { get; set; }
    }
}
