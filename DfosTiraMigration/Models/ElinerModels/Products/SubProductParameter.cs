using DfosTiraMigration.Models.ElinerModels.PriceLists;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.ElinerModels.Products
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

        [Required]
        public bool IsReadOnly { get; set; } = false;

        public virtual PriceListParameter PriceListParameter { get; set; }
    }
}