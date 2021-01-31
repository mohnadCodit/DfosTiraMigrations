﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.GoMakeModels.Searches
{
    public class ProfitsSearch
    {
        public Guid? PriceListId { get; set; }

        public Guid? ProductId { get; set; }

        public Guid? PercentageProfitId { get; set; }

        public string PriceListName { get; set; }

        public string ProductName { get; set; }

        public double OOCost { get; set; }
    }
}