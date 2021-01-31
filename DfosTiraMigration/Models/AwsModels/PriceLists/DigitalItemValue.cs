using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DfosTiraMigration.Models.AwsModels.PriceListsModels
{
    public class DigitalItemValue
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DigitalItemValue()
        {
            //OrderItems = new HashSet<OrderItem>();
            //PriceListItems = new HashSet<PriceListItem>();
           
        }

        public int ID { get; set; }

        public double Quantity { get; set; }

        public int TypesQuantity { get; set; }

        public string SetsQuantity { get; set; }

       // public double? SetsUnit { get; set; }

        public string PrintingSize { get; set; }

        public string Width { get; set; }

        public string Height { get; set; }

        //public bool IsPrintingWithoutBackground { get; set; }

        public string Side { get; set; }

        public string Color { get; set; }

        public string PaperType { get; set; }

        public string ChromeWeight { get; set; }

        public string StickerWeight { get; set; }

        public string WoodWeight { get; set; }

       // public string DuplexWeight { get; set; }

        public string SpecialWeight { get; set; }

        public string PaperPrice { get; set; }

        public string Laminate { get; set; }

        //public string Mate { get; set; }

        public bool Magnet { get; set; }

        public bool BIG { get; set; }

        //public double? BIGWidth { get; set; }

        //public double? BIGHeight { get; set; }

        public bool Fold { get; set; }

        //public double? FoldWidth { get; set; }

        //public double? FoldHeight { get; set; }

        public bool isBlocks { get; set; }

        public bool Proportion { get; set; }

        //public double? ProportionWidth { get; set; }

        //public double? ProportionHeight { get; set; }

//        public bool Perforation { get; set; }

        //public double? PerforationQuantity { get; set; }

        //public double? PerforationRadius { get; set; }

        public bool RoundedCorners { get; set; }

        public bool ChangingData { get; set; }

        public bool PinsForSets { get; set; }

        public bool BusinessCard { get; set; }

        public bool Nitim { get; set; }

        //public string Printing { get; set; }

       // public string BIGType { get; set; }

        //public double? BIGTypeWidth { get; set; }

        //public double? BIGTypeHeight { get; set; }

        public string Gold { get; set; }

        //public string GoldType { get; set; }

        public string Packages { get; set; }

        public string BlocksQuantity { get; set; }

        //public bool Infection { get; set; }

        //public double? ManualAddition { get; set; }

        //public double? ManualAdditionQuantity { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<OrderItem> OrderItems { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<QuoteItem> QuoteItems { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<ItemSpecialColor> SpecialColors { get; set; }

       // [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Scodix> Scodixes { get; set; }
    }
}