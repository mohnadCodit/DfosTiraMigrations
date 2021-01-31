namespace DfosTiraMigration.Models.GoMakeModels.PriceListsModels
{
    using DfosTiraMigration.Models.GoMakeModels.PriceLists;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PriceListParametersBoard
    {
        public Guid ID { get; set; }

        public Guid PriceListParameterId { get; set; }

        public Guid BoardId { get; set; }

        public virtual Boards Board { get; set; }

        public virtual PriceListParameter PriceListParameter { get; set; }
    }
}
