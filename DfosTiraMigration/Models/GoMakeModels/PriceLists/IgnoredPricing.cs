using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DfosTiraMigration.Models.GoMakeModels.PriceLists
{
    [Table("IgnoredPricing")]
    public class IgnoredPricing
    {
        public Guid ID { get; set; }

        public Guid ClientId { get; set; }

        public Guid PriceListId { get; set; }

        public virtual Client Client { get; set; }

        public virtual PriceList PriceList { get; set; }
    }
}