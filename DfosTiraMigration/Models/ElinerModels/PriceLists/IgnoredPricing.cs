using System.ComponentModel.DataAnnotations.Schema;

namespace DfosTiraMigration.Models.ElinerModels.PriceLists
{
    [Table("IgnoredPricing")]
    public class IgnoredPricing
    {
        public int ID { get; set; }

        public int ClientId { get; set; }

        public int PriceListId { get; set; }

        public virtual Client Client { get; set; }

        public virtual PriceList PriceList { get; set; }
    }
}