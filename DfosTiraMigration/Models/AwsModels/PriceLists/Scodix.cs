namespace DfosTiraMigration.Models.AwsModels.PriceListsModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Scodix")]
    public partial class Scodix
    {
        public int ID { get; set; }

        public int DigitalItemValueId { get; set; }

        [Required]
        public string Gold { get; set; }

        [Required]
        public string Gray { get; set; }

        [Required]
        public string ScodixPercent { get; set; }

        public virtual DigitalItemValue DigitalItemValue { get; set; }
    }
}
