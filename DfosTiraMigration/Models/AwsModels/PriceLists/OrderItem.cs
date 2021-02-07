using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using AutoMapper;
using DfosTiraMigration.Models.AwsModels;
using DfosTiraMigration.Models.AwsModels.Products;

namespace DfosTiraMigration.Models.AwsModels.PriceListsModels
{
    public class OrderItem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrderItem()
        {
            Analytics = new HashSet<Analytic>();
            BoardMissions = new HashSet<BoardMissions>();
            OrderItemFiles = new HashSet<OrderItemFile>();
        }

        public int ID { get; set; }

        public int OrderID { get; set; }

        public int ProductID { get; set; }

        [Required]
        public double Quantity { get; set; }

        [Required]
        public double FinalPrice { get; set; }

        [Required]
        public double Price { get; set; }

        public int? DigitalPriceListID { get; set; }

        public int? EnvelopesPriceListID { get; set; }

        public string PrintingNotes { get; set; }

        public string GraphicNotes { get; set; }

        public int? NotepadPriceListID { get; set; }

        public int? PrintingPriceListID { get; set; }

        public int? BooksPriceListID { get; set; }

        public int? ShelfProductsPriceListID { get; set; }

        public int? ProductsPriceListID { get; set; }

        public int? BidPriceListID { get; set; }

        public string MissionNumber { get; set; }

        [ForeignKey("RelatedOrderItem")]
        public int? ForItemID { get; set; }

        public string Content { get; set; }

        public string WorkName { get; set; }

        public bool IsNeedGraphics { get; set; }

        public bool IsOO { get; set; }

        public double? discount { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Analytic> Analytics { get; set; }

        public virtual BidItemValue BidPriceList { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BoardMissions> BoardMissions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderItemFile> OrderItemFiles { get; set; }

        public virtual BooksItemValue BooksPriceList { get; set; }

        public virtual DigitalItemValue DigitalPriceList { get; set; }

        public virtual EnvelopesItemValue EnvelopesPriceList { get; set; }

        public virtual NotepadItemValue NotepadPriceList { get; set; }

        public virtual Order Order { get; set; }

        public virtual PrintingItemValue PrintingPriceList { get; set; }

        [ForeignKey("ProductID")]
        public virtual SubProduct SubProduct { get; set; }

        public virtual ProductsItemValue ProductsPriceList { get; set; }

        public virtual ShelfProductsItemValue ShelfProductsPriceList { get; set; }

        public virtual OrderItem RelatedOrderItem { get; set; }

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
    }
}