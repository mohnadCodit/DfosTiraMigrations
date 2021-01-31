using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.AwsModels.DataTable
{
    public class OrderGridSource
    {
        public int ID { get; set; }

        public string CreationDate { get; set; }

        public string OrderNumber { get; set; }

        public int CustomerId { get; set; }

        public string CustomerName { get; set; }

        public string PurchaseNumber { get; set; }

        public int OrderItemsNumber { get; set; }

        public string TotalPrice { get; set; }

        public string Notes { get; set; }

        public string Status { get; set; }

        public bool IsReady { get; set; }

        public bool IsHaveDelivery { get; set; }

        public string DeliveryNumber { get; set; }

        public bool IsClosed { get; set; }

        public string Key { get; set; }

        public string DeliveryStatus { get; set; }

        public bool isFullyDelivered { get; set; }

        public string AccountingNumber { get; set; }

        public string totalPrice { get; set; }
    }
}