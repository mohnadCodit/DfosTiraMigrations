using DfosTiraMigration.Models.GoMakeModels.PriceListsModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.GoMakeModels.Logs
{
    public class OrdersLog
    {
        public OrdersLog()
        {
            ID = Guid.NewGuid();
        }
        public Guid ID { get; set; }

        public int LogTypeId { get; set; }

        public Guid UserId { get; set; }

        public Guid OrderId { get; set; }

        public DateTime CreationDate { get; set; }

        public string Description { get; set; }

        public virtual User User { get; set; }

        public virtual Order Order { get; set; }
        public int? DID { get; set; }

        public Guid? PrintHouseId { get; set; }
    }
}