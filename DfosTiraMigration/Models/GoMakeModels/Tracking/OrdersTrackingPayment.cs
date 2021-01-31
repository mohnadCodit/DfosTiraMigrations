
using System;
using System.ComponentModel.DataAnnotations;

namespace DfosTiraMigration.Models.GoMakeModels.Tracking
{
    public class OrdersTrackingPayment
    {
        [Required]
        public Guid ID { get; set; }

        [Required]
        public Guid OrdersTrackingId { get; set; }

        [Required]
        public double Payment { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }

        public virtual OrdersTracking OrdersTracking { get; set; }
    }
}