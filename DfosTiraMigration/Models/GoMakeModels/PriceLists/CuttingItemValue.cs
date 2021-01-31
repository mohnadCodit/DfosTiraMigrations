namespace DfosTiraMigration.Models.GoMakeModels.PriceListsModels
{
    using System;
    using System.Collections.Generic;

    public partial class CuttingItemValue
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CuttingItemValue()
        {
            //OrderItems = new HashSet<OrderItem>();
            //QuoteItems = new HashSet<QuoteItem>();
           // ID = Guid.NewGuid();
        }

        public Guid ID { get; set; }

        public double Quantity { get; set; }

        public string Size { get; set; }

        public string Cutting { get; set; }

        public string BIGType { get; set; }

        public double? BIGTypeWidth { get; set; }

        public double? BIGTypeHeight { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderItem> OrderItems { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuoteItem> QuoteItems { get; set; }
    }
}
