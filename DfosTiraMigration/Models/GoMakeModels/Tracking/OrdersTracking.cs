using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DfosTiraMigration.Models.GoMakeModels.PriceListsModels;

namespace DfosTiraMigration.Models.GoMakeModels.Tracking
{
    [Table("OrdersTracking")]
    public class OrdersTracking
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrdersTracking()
        {
            OrdersTrackingPayments = new HashSet<OrdersTrackingPayment>();
            ID = Guid.NewGuid();
        }

        [Required]
        public Guid ID { get; set; }

        [Required]
        public Guid orderId { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }

        public virtual Order Order { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdersTrackingPayment> OrdersTrackingPayments { get; set; }
    }
}