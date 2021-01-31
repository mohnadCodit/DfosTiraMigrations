﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DfosTiraMigration.Models.AwsModels.PriceListsModels
{
    public class BidItemValue
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BidItemValue()
        {
            OrderItems = new HashSet<OrderItem>();
            QuoteItems = new HashSet<QuoteItem>();
        }

        public int ID { get; set; }

        public string White { get; set; }

        [ForeignKey("BidItemValueShtansim")]
        public int? ShtansID { get; set; }

        public string isMate { get; set; }

        public string Finishing { get; set; }

        public int ShtansShapeID { get; set; }

        public string PaperWidth { get; set; }

        public string CustomerQuantityRequirement { get; set; }

        [Required]
        public string Height { get; set; }
        [Required]
        public string type { get; set; }
        [Required]
        public double Quantity { get; set; }
        [Required]
        public string TypesQuantity { get; set; }
        [Required]
        public string Color { get; set; }
        [Required]
        public string RunningDirection { get; set; }
        [Required]
        public string Radius { get; set; }
        [Required]
        public string EstimatedRollsQuantity { get; set; }
        [Required]
        public string EstimatedStickerQuantity { get; set; }
        [Required]
        public string Width { get; set; }

        public virtual BidItemValueShtansim BidItemValueShtansim { get; set; }
        public virtual ShtansShape ShtansShape { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderItem> OrderItems { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuoteItem> QuoteItems { get; set; }
    }
}