using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.AwsModels.DataTable
{
    public class BoardMissionGridSource
    {
        public int ID { get; set; }

        public string DueDate { get; set; }

        public int CustomerId { get; set; }

        public string CustomerName { get; set; }

        public string OrderNumber { get; set; }

        public string SubProductName { get; set; }

        public string WhereIsInKanban { get; set; }

        public bool isNeedDelivery { get; set; }

        public string Number { get; set; }

        public bool isReady { get; set; }

        public int IsNotDynamicMissionsInOrder { get; set; }

        public int OrderItemID { get; set; }

        public int SourceIdentity { get; set; }

        public bool isNeedButtons { get; set; }

        public double totalPrice { get; set; }

        public string WorkName { get; set; }

        public Guid OrderKey { get; set; }
    }
}