//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BuyalotV1._0.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class 
        OrderModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrderModel()
        {
            this.OrderDetails = new HashSet<OrderDetailModel>();
            this.Payments = new HashSet<PaymentModel>();
        }
    
        [Key]
        public int orderID { get; set; }
        public int customerID { get; set; }
        public System.DateTime orderDate { get; set; }
        public System.DateTime shippingDate { get; set; }
        public string shippingAddress { get; set; }
        public string status { get; set; }
        public decimal totalPrice { get; set; }
    
        public virtual CustomerModel Customer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetailModel> OrderDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PaymentModel> Payments { get; set; }
    }
}
