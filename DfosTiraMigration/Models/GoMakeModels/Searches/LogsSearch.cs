using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.GoMakeModels.Searches
{
    public class LogsSearch
    {

        public int? table { get; set; }

        public Guid? userId { get; set; }

        public Guid? orderId { get; set; }

        public Guid? quoteId { get; set; }

        public int? logTypeId { get; set; }

        public Guid? boardMissionId { get; set; }

        public bool? isCritical { get; set; }

        public string dateRange { get; set; }

        public string searchedItemNumber { get; set; }
    }
}