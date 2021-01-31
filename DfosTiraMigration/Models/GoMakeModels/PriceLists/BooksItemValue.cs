using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.GoMakeModels.PriceListsModels
{
    public class BooksItemValue
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BooksItemValue()
        {
            //OrderItems = new HashSet<OrderItem>();
            //QuoteItems = new HashSet<QuoteItem>();
            Covers = new HashSet<Cover>();
            IntireColumns = new HashSet<IntireColumn>();
            //ID = Guid.NewGuid();
        }

        public Guid ID { get; set; }

        public double Quantity { get; set; }

        public string Size { get; set; }

        public string Width { get; set; }

        public string Height { get; set; }

        public string Finishing { get; set; }

        public string FinishingDirection { get; set; }

        public string SpiralType { get; set; }

        public string SpiralColor { get; set; }

        public string NitimType { get; set; }

        public bool IsPrintingWithoutBackground { get; set; }

        public bool Sewing { get; set; }

        public bool Magnet { get; set; }

        public bool Flips { get; set; }

        public double? MagnetQuantity { get; set; }

        public double? MagnetWidth { get; set; }

        public double? MagnetHeight { get; set; }

        public double? ManualAddition { get; set; }

        public double? ManualAdditionQuantity { get; set; }

        public bool FilingHoles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cover> Covers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IntireColumn> IntireColumns { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderItem> OrderItems { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuoteItem> QuoteItems { get; set; }

        [NotMapped]
        public bool isNeedSecondIntireColumns { get; set; }
        [NotMapped]
        public bool isNeedCovers { get; set; }
    }
}