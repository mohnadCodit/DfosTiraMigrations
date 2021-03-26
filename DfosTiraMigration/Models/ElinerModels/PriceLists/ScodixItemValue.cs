namespace DfosTiraMigration.Models.ElinerModels.PriceListsModels
{
    using System.Collections.Generic;

    public partial class ScodixItemValue
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ScodixItemValue()
        {
            //OrderItems = new HashSet<OrderItem>();
            //QuoteItems = new HashSet<QuoteItem>();
            Scodixes = new HashSet<Scodix>();
        }

        public int ID { get; set; }

        public double Quantity { get; set; }

        public string Size { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderItem> OrderItems { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuoteItem> QuoteItems { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Scodix> Scodixes { get; set; }
    }
}
