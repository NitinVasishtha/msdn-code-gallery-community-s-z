//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace wpf_EntityFramework.EntityData
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order  :IEntityWithId
    {
        public Order()
        {
            this.OrderLines = new HashSet<OrderLine>();
        }
    
        public int Id { get; set; }
        public Nullable<System.DateTime> DeliveryDate { get; set; }
        public Nullable<int> CustomerId { get; set; }
        public Nullable<decimal> TotalPrice { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual ICollection<OrderLine> OrderLines { get; set; }
    }
}
