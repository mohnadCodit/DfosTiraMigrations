using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.GoMakeModels.PriceListsModels
{
    public class EnvelopesItemValue
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EnvelopesItemValue()
        {
            //OrderItems = new HashSet<OrderItem>();
            //PriceListItems = new HashSet<PriceListItem>();
            ItemSpecialColors = new HashSet<ItemSpecialColor>();
           // ID = Guid.NewGuid();
        }

        public Guid ID { get; set; }

        public string Size { get; set; }

        public string Color { get; set; }

        public string Sticker { get; set; }

        public double Quantity { get; set; }

        public string EnvelopName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderItem> OrderItems { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuoteItem> QuoteItems { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemSpecialColor> ItemSpecialColors { get; set; }

        [NotMapped]
        public bool isNeedSpecialColors { get; set; }
    }
}