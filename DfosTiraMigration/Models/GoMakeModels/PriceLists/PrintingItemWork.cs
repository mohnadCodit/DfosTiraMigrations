using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.GoMakeModels.PriceListsModels
{
    public class PrintingItemWork
    {
        public Guid ID { get; set; }

        public string WorkName { get; set; }

        [Required]
        public double Quantity { get; set; }

        [Required]
        public string Width { get; set; }

        [Required]
        public string Height { get; set; }

        [ForeignKey("PrintingItemValue")]
        public Guid PrintingPriceListID { get; set; }

        public virtual PrintingItemValue PrintingItemValue { get; set; }
    }
}