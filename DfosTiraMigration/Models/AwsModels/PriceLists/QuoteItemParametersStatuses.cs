namespace DfosTiraMigration.Models.AwsModels.PriceListsModels
{
    using DfosTiraMigration.Models.AwsModels.PriceLists;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QuoteItemParametersStatuses")]
    public partial class QuoteItemParametersStatuses
    {
        public int ID { get; set; }

        public int QuoteItemId { get; set; }

        public int PriceListParameterId { get; set; }

        public bool IsReady { get; set; }

        public bool IsOO { get; set; }

        public int? BusinessPartnerId { get; set; }

        public double? Cost { get; set; }

        public string Name { get; set; }

        public string Value { get; set; }

        public virtual QuoteItem QuoteItem { get; set; }

        public virtual PriceListParameter PriceListParameter { get; set; }

        public virtual BusinessPartner BusinessPartner { get; set; }
    }
}
