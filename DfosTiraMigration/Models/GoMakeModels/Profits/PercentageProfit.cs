using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DfosTiraMigration.Models.GoMakeModels
{
    public partial class PercentageProfit
    {
        public Guid ID { get; set; }

        public Guid PercentageProfitsGroupId { get; set; }

        public double XPoint { get; set; }

        public double YPoint { get; set; }

        public virtual PercentageProfitsGroup PercentageProfitsGroup { get; set; }

        [NotMapped]
        public List<double> rowInput { get; set; }

        [NotMapped]
        public Guid? PriceListId { get; set; }

        [NotMapped]
        public Guid? ProductId { get; set; }
    }
}
