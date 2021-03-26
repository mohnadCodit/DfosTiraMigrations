using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DfosTiraMigration.Models.ElinerModels.PriceListsModels
{
    public class IntireColumn
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IntireColumn()
        {
            ItemSpecialColors = new HashSet<ItemSpecialColor>();
            Scodixes = new HashSet<Scodix>();
        }

        public int ID { get; set; }

        [Required]
        public string Quantity { get; set; }

        public string Side { get; set; }

        public string Color { get; set; }

        public string Type { get; set; }

        public string ChromeWeight { get; set; }

        public string WoodWeight { get; set; }

        public string StickerWeight { get; set; }

        public string DuplexWeight { get; set; }

        public string SpecialWeight { get; set; }

        public string PaperPrice { get; set; }

        public string Lamination { get; set; }

        public string LaminationType { get; set; }

        public int BooksPriceListID { get; set; }

        public bool BIG { get; set; }

        public double? BIGWidth { get; set; }

        public double? BIGHeight { get; set; }

        public bool Proportion { get; set; }

        public double? ProportionWidth { get; set; }

        public double? ProportionHeight { get; set; }

        public bool ChangingData { get; set; }

        public string Cutting { get; set; }

        public string BIGType { get; set; }

        public string BIGTypeWidth { get; set; }

        public string BIGTypeHeight { get; set; }

        public string Gold { get; set; }

        public string GoldType { get; set; }

        public virtual BooksItemValue BooksItemValue { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemSpecialColor> ItemSpecialColors { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Scodix> Scodixes { get; set; }

        [NotMapped]
        public bool isNeedSpecialColors { get; set; }
        [NotMapped]
        public bool isNeedScodix { get; set; }
        [NotMapped]
        public int index { get; set; }
    }
}