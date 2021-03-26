using DfosTiraMigration.Models.ElinerModels.Tracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.ElinerModels.DataTable
{
    public class OrderTrackingGridSource
    {
        public int ID { get; set; }

        public string CreationDate { get; set; }

        public string PaymentRemain { get; set; }

        public bool isPaymentRemains { get; set; }

        public OrderGridSource order { get; set; }

        public List<OrdersTrackingPayment> Payments { get; set; }
    }
}