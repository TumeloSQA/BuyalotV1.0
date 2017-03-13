//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Admin.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class PaymentModel
    {
        [Key]
        public int paymentID { get; set; }
        public System.DateTime paymentDate { get; set; }
        public int customerID { get; set; }
        public int orderID { get; set; }
        public string paymentType { get; set; }
        public Nullable<decimal> totalPrice { get; set; }
    
        public virtual CustomerModel Customer { get; set; }
        public virtual OrderModel Order { get; set; }
    }
}
