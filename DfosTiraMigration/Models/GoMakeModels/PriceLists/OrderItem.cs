using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using AutoMapper;
using DfosTiraMigration.Models.GoMakeModels;
using DfosTiraMigration.Models.GoMakeModels.Helper;
using DfosTiraMigration.Models.GoMakeModels.Products;

namespace DfosTiraMigration.Models.GoMakeModels.PriceListsModels
{
    public class OrderItem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrderItem()
        {
            ID = Guid.NewGuid();
            Analytics = new HashSet<Analytic>();
            BoardMissions = new HashSet<BoardMissions>();
            OrderItemFiles = new HashSet<OrderItemFile>();
            OrderItemParametersStatuses = new HashSet<OrderItemParametersStatus>();
        }
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[Key]
        public Guid ID { get; set; }

        public Guid OrderID { get; set; }

        public Guid ProductID { get; set; }

        [Required]
        public double Quantity { get; set; }

        [Required]
        public double FinalPrice { get; set; }

        [Required]
        public double Price { get; set; }

        public Guid? DigitalPriceListID { get; set; }

        public Guid? EnvelopesPriceListID { get; set; }

        public string PrintingNotes { get; set; }

        public string GraphicNotes { get; set; }

        public Guid? NotepadPriceListID { get; set; }

        public Guid? PrintingPriceListID { get; set; }

        public Guid? BooksPriceListID { get; set; }

        public Guid? ShelfProductsPriceListID { get; set; }

        public Guid? ProductsPriceListID { get; set; }

        public Guid? BidPriceListID { get; set; }

        public string MissionNumber { get; set; }

        [ForeignKey("RelatedOrderItem")]
        public Guid? ForItemID { get; set; }

        public string Content { get; set; }

        public string WorkName { get; set; }

        public bool IsNeedGraphics { get; set; }

        public bool IsOO { get; set; }

        public double? discount { get; set; }

        public double? Cost { get; set; }

        public double? Comission { get; set; }

        public double? EstimatedPrice { get; set; }

        [ForeignKey("Supplier")]
        public Guid? SupplierId { get; set; }

        public double? OOCost { get; set; }

        public int? OOPartitionEnum { get; set; }

        public bool IsNeedExample { get; set; }

        public bool ExampleIsReady { get; set; }

        public bool ExampleNeedDelivery { get; set; }

        public string OOAccountingNumber { get; set; }

        [ForeignKey("ScodixItemValue")]
        public Guid? ScodixPriceListID { get; set; }

        [ForeignKey("GlassesItemValue")]
        public Guid? GlassesPriceListID { get; set; }

        [ForeignKey("CuttingItemValue")]
        public Guid? CuttingPriceListID { get; set; }

        public int? ExampleType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Analytic> Analytics { get; set; }

        public virtual BidItemValue BidPriceList { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BoardMissions> BoardMissions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderItemFile> OrderItemFiles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderItemParametersStatus> OrderItemParametersStatuses { get; set; }

        public virtual BooksItemValue BooksPriceList { get; set; }

        public virtual DigitalItemValue DigitalPriceList { get; set; }

        public virtual EnvelopesItemValue EnvelopesPriceList { get; set; }

        public virtual NotepadItemValue NotepadPriceList { get; set; }

        public virtual Order Order { get; set; }

        public virtual PrintingItemValue PrintingPriceList { get; set; }

        public virtual SubProduct SubProduct { get; set; }

        public virtual ProductsItemValue ProductsPriceList { get; set; }

        public virtual ShelfProductsItemValue ShelfProductsPriceList { get; set; }

        public virtual CuttingItemValue CuttingItemValue { get; set; }

        public virtual OrderItem RelatedOrderItem { get; set; }

        public virtual Client Supplier { get; set; }

        public virtual ScodixItemValue ScodixItemValue { get; set; }

        public virtual GlassesItemValue GlassesItemValue { get; set; }

        [NotMapped]
        public virtual BoardMissions Mission { get; set; }

        [NotMapped]
        public List<string> Files { get; set; }

        [NotMapped]
        public bool FilesToPrint { get; set; }

        [NotMapped]
        public bool FilesToGraphic { get; set; }

        [NotMapped]
        public double graphicHours { get; set; }

        [NotMapped]
        public OOParametersDetails OOParametersDetails { get; set; }

        [NotMapped]
        public bool isForDuplicate { get; set; } = false;
    }
}