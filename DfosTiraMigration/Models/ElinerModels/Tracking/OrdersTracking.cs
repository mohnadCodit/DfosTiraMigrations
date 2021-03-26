using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DfosTiraMigration.Models.ElinerModels.PriceListsModels;

namespace DfosTiraMigration.Models.ElinerModels.Tracking
{
    [Table("OrdersTracking")]
    public class OrdersTracking
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrdersTracking()
        {
            OrdersTrackingPayments = new HashSet<OrdersTrackingPayment>();
        }

        [Required]
        public int ID { get; set; }

        [Required]
        public int orderId { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }

        public virtual Order Order { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdersTrackingPayment> OrdersTrackingPayments { get; set; }
    }
}