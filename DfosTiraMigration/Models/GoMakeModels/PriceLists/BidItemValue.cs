using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DfosTiraMigration.Models.GoMakeModels.PriceListsModels
{
    public class BidItemValue
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BidItemValue()
        {
            //ID = Guid.NewGuid();
        }
        
        public Guid ID { get; set; }

        public bool White { get; set; } = false;

        [ForeignKey("BidItemValueShtansim")]
        public Guid? ShtansID { get; set; }

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

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderItem> OrderItems { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuoteItem> QuoteItems { get; set; }
        public int? DID { get; set; }
    }
}