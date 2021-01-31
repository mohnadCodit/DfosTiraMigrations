namespace DfosTiraMigration.Models.GoMakeModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OOPercentageProfit
    {
        public Guid ID { get; set; }

        public Guid OOPercentageProfitsGroupId { get; set; }

        public double XPoint { get; set; }

        public double YPoint { get; set; }

        public virtual OOPercentageProfitsGroup OOPercentageProfitsGroup { get; set; }

        [NotMapped]
        public List<double> rowInput { get; set; }

        [NotMapped]
        public Guid? PriceListId { get; set; }

        [NotMapped]
        public Guid? ProductId { get; set; }
    }
}
