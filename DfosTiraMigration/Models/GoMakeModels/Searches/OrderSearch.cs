using DfosTiraMigration.Models.GoMakeModels.DataTable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.GoMakeModels.Searches
{
    public class OrderSearch
    {
        public Guid? clientId { get; set; }

        public string clientName { get; set; }

        public string orderNumber { get; set; }

        public string dateRange { get; set; }

        public int? deliveryStatus { get; set; }

        public int? deliveryStatusEnumId { get; set; }

        public bool? isReady { get; set; }

        public int? isReadyDays { get; set; }

        public bool? IsClosed { get; set; }

        public bool? isNotFullyDelivered { get; set; }

        public string BuisnessNumber { get; set; }

        public bool? isPayed { get; set; }

        public bool? displayAll { get; set; }

        public string WorkName { get; set; }
    }
}