using DfosTiraMigration.Models.AwsModels.PriceListsModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.AwsModels.Products
{
    public class ProductsPrice
    {
        public ProductsPrice() { }

        public ProductsPrice(int count, string parameters)
        {
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

        public int ID { get; set; }

        public int SubProductID { get; set; }

        public string Parameter1 { get; set; }

        public string Parameter2 { get; set; }

        public string Parameter3 { get; set; }

        public string Parameter4 { get; set; }

        public string Parameter5 { get; set; }

        public string Parameter6 { get; set; }

        public string Parameter7 { get; set; }

        public string Parameter8 { get; set; }

        [Required]
        public string Price { get; set; }

        public string ProviderPrice { get; set; }

        public string SpecialPrice { get; set; }

        public virtual SubProduct SubProduct { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<ShelfProductsItemValue> ShelfProductsLists { get; set; }

    }
}