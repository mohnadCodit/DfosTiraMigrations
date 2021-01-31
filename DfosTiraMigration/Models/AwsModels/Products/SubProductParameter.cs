using DfosTiraMigration.Models.AwsModels.PriceLists;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.AwsModels.Products
{
    public class SubProductParameter
    {

        public int ID { get; set; }

        [Required]
        public int SubProductId { get; set; }

        [Required]
        public int PriceListParameterId { get; set; }

        public string Values { get; set; }

        public string DefaultValue { get; set; }

        [Required]
        public bool IsVisible { get; set; } = true;

        public virtual PriceListParameter PriceListParameter { get; set; }
    }
}