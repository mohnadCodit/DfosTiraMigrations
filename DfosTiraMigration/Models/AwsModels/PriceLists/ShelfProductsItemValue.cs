using DfosTiraMigration.Models.AwsModels.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.AwsModels.PriceListsModels
{
    public class ShelfProductsItemValue
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ShelfProductsItemValue()
        {
            //    OrderItems = new HashSet<OrderItem>();
            //    PriceListItems = new HashSet<PriceListItem>();
        }

        public int ID { get; set; }

        [Required]
        public double Quantity { get; set; }

        public string Parameter1 { get; set; }

        public string Parameter2 { get; set; }

        public string Parameter3 { get; set; }

        public string Parameter4 { get; set; }

        public string Parameter5 { get; set; }

        public string Parameter6 { get; set; }

        public string Parameter7 { get; set; }

        public string Parameter8 { get; set; }

        public string Price { get; set; }

        public string ProviderPrice { get; set; }

        public string SpecialPrice { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderItem> OrderItems { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuoteItem> QuoteItems { get; set; }

        //public virtual ProductsPrice ProductsPrice { get; set; }


    }
}
