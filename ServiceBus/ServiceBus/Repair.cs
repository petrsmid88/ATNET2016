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
    
    public partial class Repair
    {
        public int Id { get; set; }
        public System.Guid ProductId { get; set; }
        public string Serial { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
        public int StorageId { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual User User { get; set; }
        public virtual Storage Storage { get; set; }
    }
}
