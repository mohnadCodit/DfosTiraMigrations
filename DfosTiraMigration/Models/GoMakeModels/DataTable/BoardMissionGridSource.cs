using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.GoMakeModels.DataTable
{
    public class BoardMissionGridSource
    {
        public Guid ID { get; set; }

        public string DueDate { get; set; }

        public Guid CustomerId { get; set; }

        public string CustomerName { get; set; }

        public string OrderNumber { get; set; }

        public string SubProductName { get; set; }

        public string WhereIsInKanban { get; set; }

        public bool isNeedDelivery { get; set; }

        public string Number { get; set; }

        public bool isReady { get; set; }

        public int IsNotDynamicMissionsInOrder { get; set; }

        public Guid OrderItemID { get; set; }

        public int SourceIdentity { get; set; }

        public bool isNeedButtons { get; set; }

        public double totalPrice { get; set; }

        public string WorkName { get; set; }

        public double? Profit { get; set; }

        public double? Cost { get; set; }

        public double? OOCost { get; set; }

        public double? Commission { get; set; }

        public string AgentName { get; set; }

        public string AgentPhone { get; set; }

        public string AgentMail { get; set; }

        public Guid? AgentId { get; set; }

        public string Suppliers { get; set; }

        public string OOPartition { get; set; }

        public Guid OrderKey { get; set; }

        public string AccountingNumber { get; set; }

        public string submission { get; set; }

        public string image { get; set; }

        public double ComissionPercent { get; set; }

        public bool isOW { get; set; }
    }
}