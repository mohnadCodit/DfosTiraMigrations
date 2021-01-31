using DfosTiraMigration.Models.GoMakeModels.PriceListsModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.GoMakeModels.Logs
{
    public class QuotesLog
    {
        public Guid ID { get; set; }

        public int LogTypeId { get; set; }

        public Guid UserId { get; set; }

        public Guid QuoteId { get; set; }

        public DateTime CreationDate { get; set; }

        public string Description { get; set; }

        public virtual User User { get; set; }

        public virtual Quote Quote { get; set; }
    }
}