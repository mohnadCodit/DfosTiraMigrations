namespace DfosTiraMigration.Models.ElinerModels
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

        public double MinProfit { get; set; }

        public double MaxProfit { get; set; }

        public double Comission { get; set; }

        public double MinComission { get; set; }

        public virtual MinimumProfitsGroup MinimumProfitsGroup { get; set; }
    }
}
