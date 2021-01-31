using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.AwsModels.Searches
{
    public class ProfitsSearch
    {
        public int? PriceListId { get; set; }

        public int? ProductId { get; set; }

        public int? PercentageProfitId { get; set; }

        public string PriceListName { get; set; }

        public string ProductName { get; set; }
    }
}