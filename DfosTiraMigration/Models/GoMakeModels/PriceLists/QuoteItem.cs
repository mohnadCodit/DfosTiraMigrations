using DfosTiraMigration.Models.GoMakeModels.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.GoMakeModels.PriceListsModels
{
    public class QuoteItem
    {

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public QuoteItem()
        {
            Analytics = new HashSet<Analytic>();
            QuoteItemFiles = new HashSet<QuoteItemFile>();
            QuoteItemParametersStatuses = new HashSet<QuoteItemParametersStatuses>();
        }

        public Guid ID { get; set; }

        public Guid QuoteID { get; set; }

        public Guid ProductID { get; set; }

        [Required]
        public double Quantity { get; set; }

        [Required]
        public double FinalPrice { get; set; }

        [Required]
        public double Price { get; set; }

        public Guid? DigitalPriceListID { get; set; }

        public Guid? EnvelopesPriceListID { get; set; }

        public Guid? NotepadPriceListID { get; set; }

        public Guid? BooksPriceListID { get; set; }

        public Guid? ShelfProductsPriceListID { get; set; }

        public Guid? ProductsPriceListID { get; set; }

        public Guid? PrintingPriceListID { get; set; }

        public Guid? BidPriceListID { get; set; }

        public string MissionNumber { get; set; }

        public double? discount { get; set; }

        [ForeignKey("RelatedPriceListItem")]
        public Guid? ForItemID { get; set; }

        public string Content { get; set; }

        public string PrintingNotes { get; set; }

        public string GraphicNotes { get; set; }

        public string WorkName { get; set; }

        public bool IsNeedGraphics { get; set; }

        public bool IsOO { get; set; }

        public double? Cost { get; set; }

        public double? Comission { get; set; }

        public double? EstimatedPrice { get; set; }

        [ForeignKey("Supplier")]
        public Guid? SupplierId { get; set; }

        public double? OOCost { get; set; }

        public int? OOPartitionEnum { get; set; }

        public bool IsNeedExample { get; set; }

        public bool ExampleNeedDelivery { get; set; }

        [ForeignKey("ScodixItemValue")]
        public Guid? ScodixPriceListID { get; set; }

        [ForeignKey("GlassesItemValue")]
        public Guid? GlassesPriceListID { get; set; }

        [ForeignKey("CuttingItemValue")]
        public Guid? CuttingPriceListID { get; set; }

        public int? ExampleType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Analytic> Analytics { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuoteItemFile> QuoteItemFiles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuoteItemParametersStatuses> QuoteItemParametersStatuses { get; set; }

        public virtual BidItemValue BidPriceList { get; set; }

        public virtual BooksItemValue BooksPriceList { get; set; }

        public virtual DigitalItemValue DigitalPriceList { get; set; }

        public virtual EnvelopesItemValue EnvelopesPriceList { get; set; }

        public virtual NotepadItemValue NotepadPriceList { get; set; }

        public virtual ScodixItemValue ScodixItemValue { get; set; }

        public virtual GlassesItemValue GlassesItemValue { get; set; }

        public virtual CuttingItemValue CuttingItemValue { get; set; }

        public virtual Quote Quote { get; set; }

        public virtual PrintingItemValue PrintingPriceList { get; set; }

        public virtual SubProduct SubProduct { get; set; }

        public virtual ProductsItemValue ProductsPriceList { get; set; }

        public virtual ShelfProductsItemValue ShelfProductsPriceList { get; set; }

        public virtual QuoteItem RelatedPriceListItem { get; set; }

        public virtual Client Supplier { get; set; }
    }
}