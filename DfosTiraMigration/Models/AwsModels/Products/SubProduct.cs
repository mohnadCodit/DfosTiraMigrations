using DfosTiraMigration.Models.AwsModels.PriceListsModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.AwsModels.Products
{
    public class SubProduct
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SubProduct()
        {
            ProductsPrices = new HashSet<ProductsPrice>();
            ProductsParameters = new HashSet<ProductsParameter>();
            SubProductParameters = new HashSet<SubProductParameter>();
            ProductsGroupsRelations = new HashSet<ProductsGroupsRelation>();
        }

        public int ID { get; set; }

        public string Name { get; set; }

        public int MainProductID { get; set; }

        public string Description { get; set; }

        public int ProductTypeID { get; set; }

        public int BelongTo { get; set; }

        public int? BoardID { get; set; }

        public int? ColumnID { get; set; }

        public int? RowID { get; set; }

        public bool IsSelectable { get; set; } = false;

        public bool IsActive { get; set; } = true;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductsGroupsRelation> ProductsGroupsRelations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductsPrice> ProductsPrices { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductsParameter> ProductsParameters { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuoteItem> PriceListItems { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderItem> OrderItems { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubProductParameter> SubProductParameters { get; set; }
        
        public virtual ProductsType ProductType { get; set; }

        public virtual Boards Board { get; set; }

        public virtual BoardColumns Column { get; set; }

        public virtual BoardRows Row { get; set; }

        public virtual MainProduct MainProduct { get; set; }


    }
}