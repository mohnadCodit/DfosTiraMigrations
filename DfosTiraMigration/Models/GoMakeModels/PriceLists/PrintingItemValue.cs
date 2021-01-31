using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.GoMakeModels.PriceListsModels
{
    public class PrintingItemValue
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PrintingItemValue()
        {
            //OrderItems = new HashSet<OrderItem>();
            //PriceListItems = new HashSet<PriceListItem>();
            PrintingPriceListWorks = new HashSet<PrintingItemWork>();
           // ID = Guid.NewGuid();
        }

        public Guid ID { get; set; }

        public string MaterialType { get; set; }

        public string Sticker { get; set; }

        public string Shemshonet { get; set; }

        public string Paper { get; set; }

        public string Cloth { get; set; }

        public string Special { get; set; }

        public string Hard { get; set; }

        public string Mate { get; set; }

        public string Printing { get; set; }

        public string PrintingType { get; set; }

        public string Cutting { get; set; }

        public string Side { get; set; }

        public string StickerColor { get; set; }

        public string StickerElseColor { get; set; }

        public string Lamination { get; set; }

        public bool Capsulation { get; set; }

        public bool Application { get; set; }

        public bool FloorLamination { get; set; }

        public bool Perforation { get; set; }

        public double? PerorationQuantity { get; set; }

        public string ShemshonetFinishing { get; set; }

        public string Rings { get; set; }

        public double? RingsDistance { get; set; }

        public string ClothFinishing { get; set; }

        public bool Silicone { get; set; }

        public double? PlexiglasThickness { get; set; }

        public string PlexiglasColor { get; set; }

        public string PlexiglasSpacers { get; set; }

        public double? LockbondThickness { get; set; }

        public string LockbondColor { get; set; }

        public string PVCColor { get; set; }

        public double? PVCThickness { get; set; }

        public string CapaColor { get; set; }

        public double? CapaThickness { get; set; }

        public bool CapaRacks { get; set; }

        public bool AluminumFraming { get; set; }

        public bool CardboardLeg { get; set; }

        public double? MagnetThickness { get; set; }

        public bool RingsForSignage { get; set; }

        public double? RingsForSignageQuantity { get; set; }

        public string FinishingNotes { get; set; }

        public bool Installation { get; set; }

        public double? ManualAddition { get; set; }

        public double? ManualAdditionQuantity { get; set; }

        public bool White { get; set; }

        public bool IsSetsQuantity { get; set; }

        public double? SetsQuantity { get; set; }

        public double? SetsProductsQuantity { get; set; }

        public double? SetWidth { get; set; }

        public double? SetHeight { get; set; }

        public bool WithoutBleed { get; set; }

        public string PrintingQuality { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderItem> OrderItems { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuoteItem> QuoteItems { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrintingItemWork> PrintingPriceListWorks { get; set; }
    }
}