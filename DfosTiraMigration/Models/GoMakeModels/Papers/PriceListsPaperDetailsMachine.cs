namespace DfosTiraMigration.Models.GoMakeModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PriceListsPaperDetailsMachine
    {
        public Guid ID { get; set; }

        public Guid PriceListsPapersDetailsId { get; set; }

        public Guid PriceListMachineId { get; set; }

        public double? Value { get; set; }

        public virtual PriceListsMachine PriceListsMachine { get; set; }

        public virtual PriceListsPapersDetail PriceListsPapersDetail { get; set; }
    }
}
