namespace DfosTiraMigration.Models.AwsModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OOPercentageProfit
    {
        public int ID { get; set; }

        public int OOPercentageProfitsGroupId { get; set; }

        public double XPoint { get; set; }

        public double YPoint { get; set; }

        public virtual OOPercentageProfitsGroup OOPercentageProfitsGroup { get; set; }

        [NotMapped]
        public List<double> rowInput { get; set; }

        [NotMapped]
        public int? PriceListId { get; set; }

        [NotMapped]
        public int? ProductId { get; set; }
    }
}
