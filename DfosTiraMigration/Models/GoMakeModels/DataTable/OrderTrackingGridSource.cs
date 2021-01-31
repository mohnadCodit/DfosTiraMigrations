using DfosTiraMigration.Models.GoMakeModels.Tracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.GoMakeModels.DataTable
{
    public class OrderTrackingGridSource
    {
        public Guid ID { get; set; }

        public string CreationDate { get; set; }

        public string PaymentRemain { get; set; }

        public bool isPaymentRemains { get; set; }

        public OrderGridSource order { get; set; }

        public List<OrdersTrackingPayment> Payments { get; set; }
    }
}