using DfosTiraMigration.Models.GoMakeModels.PriceListsModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.GoMakeModels.Products
{
    public class ProductsPrice
    {
        public ProductsPrice() { }

        public ProductsPrice(int count, string parameters)
        {
            ID = Guid.NewGuid();
            var split = parameters.Split(',').ToList();
            Parameter1 = split[0];
            if (split.Count > 1)
                Parameter2 = split[1];
            if (split.Count > 2)
                Parameter3 = split[2];
            if (split.Count > 3)
                Parameter4 = split[3];
            if (split.Count > 4)
                Parameter5 = split[4];
            if (split.Count > 5)
                Parameter6 = split[5];
            if (split.Count > 6)
                Parameter7 = split[6];
            if (split.Count > 7)
                Parameter8 = split[7];
        }

        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }

        public override bool Equals(Object obj)
        {
            //Check for null and compare run-time types.
            var compared = (ProductsPrice)obj;
            return this.Parameter1 == compared.Parameter1
            && this.Parameter2 == compared.Parameter2
            && this.Parameter3 == compared.Parameter3
            && this.Parameter4 == compared.Parameter4
            && this.Parameter5 == compared.Parameter5
            && this.Parameter6 == compared.Parameter6
            && this.Parameter7 == compared.Parameter7
            && this.Parameter8 == compared.Parameter8;
        }


        public Guid ID { get; set; }

        public Guid SubProductID { get; set; }

        public string Parameter1 { get; set; }

        public string Parameter2 { get; set; }

        public string Parameter3 { get; set; }

        public string Parameter4 { get; set; }

        public string Parameter5 { get; set; }

        public string Parameter6 { get; set; }

        public string Parameter7 { get; set; }

        public string Parameter8 { get; set; }

        [Required]
        public double Price { get; set; }

        //public string ProviderPrice { get; set; }

        //public string SpecialPrice { get; set; }

        public virtual SubProduct SubProduct { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<ShelfProductsItemValue> ShelfProductsLists { get; set; }

    }
}