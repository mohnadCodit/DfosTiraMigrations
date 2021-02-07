using DfosTiraMigration.Models.AwsModels.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.AwsModels.PriceListsModels
{
    public class QuoteItem
    {

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public QuoteItem()
        {
            Analytics = new HashSet<Analytic>();
            QuoteItemFiles = new HashSet<QuoteItemFile>();
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

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Analytic> Analytics { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuoteItemFile> QuoteItemFiles { get; set; }

        public virtual BidItemValue BidPriceList { get; set; }

        public virtual BooksItemValue BooksPriceList { get; set; }

        public virtual DigitalItemValue DigitalPriceList { get; set; }

        public virtual EnvelopesItemValue EnvelopesPriceList { get; set; }

        public virtual NotepadItemValue NotepadPriceList { get; set; }

        public virtual Quote Quote { get; set; }

        public virtual PrintingItemValue PrintingPriceList { get; set; }

        [ForeignKey("ProductID")]
        public virtual SubProduct SubProduct { get; set; }

        public virtual ProductsItemValue ProductsPriceList { get; set; }

        public virtual ShelfProductsItemValue ShelfProductsPriceList { get; set; }

        public virtual QuoteItem RelatedPriceListItem { get; set; }
    }
}