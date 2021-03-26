namespace DfosTiraMigration.Models.ElinerModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PriceListsPaperDetailsMachine
    {
        public int ID { get; set; }

        public int PriceListsPapersDetailsId { get; set; }

        public int PriceListMachineId { get; set; }

        public double? Value { get; set; }

        public virtual PriceListsMachine PriceListsMachine { get; set; }

        public virtual PriceListsPapersDetail PriceListsPapersDetail { get; set; }
    }
}
