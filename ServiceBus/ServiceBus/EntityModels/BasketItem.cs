
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace ServiceBus.EntityModels
{

using System;
    using System.Collections.Generic;
    
public partial class BasketItem
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public BasketItem()
    {

        this.Quantity = 1;

    }


    public System.Guid ProductId { get; set; }

    public System.Guid BasketId { get; set; }

    public int Quantity { get; set; }

    public System.Guid Id { get; set; }



    public virtual Product Product { get; set; }

    public virtual Basket Basket { get; set; }

}

}