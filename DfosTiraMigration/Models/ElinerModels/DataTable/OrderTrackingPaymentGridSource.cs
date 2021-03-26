using System;

namespace DfosTiraMigration.Models.ElinerModels.DataTable
{
    public class OrderTrackingPaymentGridSource
    {
        public int ID { get; set; }

        public string CreationDate { get; set; }

        public double Payment { get; set; }

        public double TotalPayments { get; set; }
    }
}