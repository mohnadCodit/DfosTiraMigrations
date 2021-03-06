﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.AwsModels.SapB1
{
    public class SapOrder
    {
        public string ClientCode { get; set; }
        public string Comments { get; set; }
        public string PurchaseNumber { get; set; }
        public DateTime DueDate { get; set; }

        public List<SapOrderItem> OrderItems { get; set; }
    }

    public class SapOrderItem
    {
        public string Code { get; set; }
        //public double Price { get; set; }
        public double UnitPrice { get; set; }
        public double Quantity { get; set; }
        public double DiscountPercent { get; set; }
        public string Description { get; set; }
    }
}