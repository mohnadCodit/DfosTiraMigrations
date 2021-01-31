namespace DfosTiraMigration.Models.AwsModels.PriceListsModels
{
    using DfosTiraMigration.Models.AwsModels.PriceLists;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PriceListParametersBoard
    {
        public int ID { get; set; }

        public int PriceListParameterId { get; set; }

        public int BoardId { get; set; }

        public virtual Boards Board { get; set; }

        public virtual PriceListParameter PriceListParameter { get; set; }
    }
}
