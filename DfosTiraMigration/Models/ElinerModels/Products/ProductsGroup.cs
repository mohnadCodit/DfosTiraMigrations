using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.ElinerModels.Products
{
    public class ProductsGroup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProductsGroup()
        {
            ProductsGroupsRelations = new HashSet<ProductsGroupsRelation>();
        }

        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductsGroupsRelation> ProductsGroupsRelations { get; set; }
    }
}