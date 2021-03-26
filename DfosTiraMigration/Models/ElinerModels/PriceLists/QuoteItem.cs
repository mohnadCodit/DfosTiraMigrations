using DfosTiraMigration.Models.ElinerModels.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.ElinerModels.PriceListsModels
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

        public int ID { get; set; }

        public int QuoteID { get; set; }

        public int ProductID { get; set; }

        [Required]
        public double Quantity { get; set; }

        [Required]
        public double FinalPrice { get; set; }

        [Required]
        public double Price { get; set; }

        public int? DigitalPriceListID { get; set; }

        public int? EnvelopesPriceListID { get; set; }

        public int? NotepadPriceListID { get; set; }

        public int? BooksPriceListID { get; set; }

        public int? ShelfProductsPriceListID { get; set; }

        public int? ProductsPriceListID { get; set; }

        public int? PrintingPriceListID { get; set; }

        public int? BidPriceListID { get; set; }

        public string MissionNumber { get; set; }

        public double? discount { get; set; }

        [ForeignKey("RelatedPriceListItem")]
        public int? ForItemID { get; set; }

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
        public int? SupplierId { get; set; }

        public double? OOCost { get; set; }

        public int? OOPartitionEnum { get; set; }

        public bool IsNeedExample { get; set; }

        public bool ExampleNeedDelivery { get; set; }

        [ForeignKey("ScodixItemValue")]
        public int? ScodixPriceListID { get; set; }

        [ForeignKey("GlassesItemValue")]
        public int? GlassesPriceListID { get; set; }

        [ForeignKey("CuttingItemValue")]
        public int? CuttingPriceListID { get; set; }

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