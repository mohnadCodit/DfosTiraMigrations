using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.GoMakeModels.Searches
{
    public class ORMissionsSearch
    {
        public Guid? clientId { get; set; }

        public string clientName { get; set; }

        public string dateRange { get; set; }

        public bool? isReady { get; set; }

        public bool? isNeedDelivery { get; set; }

        public Guid? orderId { get; set; }

        public int? Days { get; set; }

        public int? Hours { get; set; }

        public Guid? columnId { get; set; }

        public Guid? boardId { get; set; }

        public Guid? rowId { get; set; }

        public int? logTypeEnumId { get; set; }

        public string columnName { get; set; }

        public Guid? productID { get; set; }

        public string productName { get; set; }

        public Guid? mainProductIdproductID { get; set; }

        public string mainProductName { get; set; }

        public Guid? productGroupID { get; set; }

        public int? productGroupName { get; set; }

        public int? targetOrderId { get; set; }

        public Guid? AgentId { get; set; }

        public string AgentName { get; set; }

        public bool? isNeedExample { get; set; }
    }
}