
using System;
using System.ComponentModel.DataAnnotations;

namespace DfosTiraMigration.Models.AwsModels.Tracking
{
    public class OrdersTrackingPayment
    {
        [Required]
        public int ID { get; set; }

        [Required]
        public int OrdersTrackingId { get; set; }

        [Required]
        public double Payment { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }

        public virtual OrdersTracking OrdersTracking { get; set; }
    }
}