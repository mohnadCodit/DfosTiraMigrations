namespace DfosTiraMigration.Models.AwsModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MinimumProfit
    {
        public int ID { get; set; }

        public int MinimumProfitsGroupId { get; set; }

        public double XPoint { get; set; }

        public double YPoint { get; set; }

        public double ProfitRequest { get; set; }

        public double MinimumRequest { get; set; }

        public virtual MinimumProfitsGroup MinimumProfitsGroup { get; set; }
    }
}
