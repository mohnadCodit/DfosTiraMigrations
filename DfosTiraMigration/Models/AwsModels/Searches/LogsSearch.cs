using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.AwsModels.Searches
{
    public class LogsSearch
    {

        public int? table { get; set; }

        public int? userId { get; set; }

        public int? orderId { get; set; }

        public int? quoteId { get; set; }

        public int? logTypeId { get; set; }

        public int? boardMissionId { get; set; }

        public bool? isCritical { get; set; }

        public string dateRange { get; set; }

        public string searchedItemNumber { get; set; }
    }
}