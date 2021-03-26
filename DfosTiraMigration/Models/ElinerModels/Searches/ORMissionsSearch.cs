using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace DfosTiraMigration.Models.ElinerModels.Searches
{
    public class ORMissionsSearch
    {
        public int? clientId { get; set; }

        public string clientName { get; set; }

        public string dateRange { get; set; }

        public bool? isReady { get; set; }

        public bool? isNeedDelivery { get; set; }

        public int? orderId { get; set; }

        public int? Days { get; set; }

        public int? Hours { get; set; }

        public int? columnId { get; set; }

        public int? boardId { get; set; }

        public int? rowId { get; set; }

        public int? logTypeEnumId { get; set; }

        public string columnName { get; set; }

        public int? productID { get; set; }

        public string productName { get; set; }

        public int? mainProductIdproductID { get; set; }

        public string mainProductName { get; set; }

        public int? productGroupID { get; set; }

        public int? productGroupName { get; set; }

        public int? targetOrderId { get; set; }

        public int? AgentId { get; set; }

        public string AgentName { get; set; }

        public bool? isNeedExample { get; set; }

        public int? NumberOfRelatedJobs { get; set; }

        public string PurchaseNumber { get; set; }

        public string IsClosed { get; set; }
    }
}