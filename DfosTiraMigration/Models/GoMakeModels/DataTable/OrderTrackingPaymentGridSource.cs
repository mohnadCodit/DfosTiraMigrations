using System;

namespace DfosTiraMigration.Models.GoMakeModels.DataTable
{
    public class OrderTrackingPaymentGridSource
    {
        public Guid ID { get; set; }

        public string CreationDate { get; set; }

        public double Payment { get; set; }

        public double TotalPayments { get; set; }
    }
}