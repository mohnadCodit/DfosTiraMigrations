using DfosTiraMigration.Models.GoMakeModels.PriceLists;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.GoMakeModels.Products
{
    public class SubProductParameter
    {

        public Guid ID { get; set; }

        [Required]
        public Guid SubProductId { get; set; }

        [Required]
        public Guid PriceListParameterId { get; set; }

        public string Values { get; set; }

        public string DefaultValue { get; set; }

        [Required]
        public bool IsVisible { get; set; } = true;

        [Required]
        public bool IsReadOnly { get; set; } = false;

        public virtual PriceListParameter PriceListParameter { get; set; }
    }
}