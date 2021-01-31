using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DfosTiraMigration.Models.AwsModels
{
    public partial class PercentageProfit
    {
        public int ID { get; set; }

        public int PercentageProfitsGroupId { get; set; }

        public double XPoint { get; set; }

        public double YPoint { get; set; }

        public virtual PercentageProfitsGroup PercentageProfitsGroup { get; set; }

        [NotMapped]
        public List<double> rowInput { get; set; }

        [NotMapped]
        public int? PriceListId { get; set; }

        [NotMapped]
        public int? ProductId { get; set; }
    }
}
