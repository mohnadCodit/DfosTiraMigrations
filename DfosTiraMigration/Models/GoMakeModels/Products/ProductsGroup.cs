using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.GoMakeModels.Products
{
    public class ProductsGroup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProductsGroup()
        {
            ProductsGroupsRelations = new HashSet<ProductsGroupsRelation>();
        }

        public Guid ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public Guid PrintHouseId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductsGroupsRelation> ProductsGroupsRelations { get; set; }
    }
}