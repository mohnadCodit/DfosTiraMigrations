using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.GoMakeModels.Products
{
    public class MainProduct
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MainProduct()
        {
            SubProducts = new HashSet<SubProduct>();
            MinimumProfitsGroups = new HashSet<MinimumProfitsGroup>();
            PercentageProfitsGroups = new HashSet<PercentageProfitsGroup>();
            OOMinimumProfitsGroups = new HashSet<OOMinimumProfitsGroup>();
            OOPercentageProfitsGroups = new HashSet<OOPercentageProfitsGroup>();
            MainProductSuppliers = new HashSet<MainProductSupplier>();
        }

        public Guid ID { get; set; }

        [Required]
        public string Name { get; set; }

        public Guid PrintHouseId { get; set; }

        [Required]
        public string Code { get; set; }

        [NotMapped]
        public Guid[] suppliers { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubProduct> SubProducts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PercentageProfitsGroup> PercentageProfitsGroups { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MinimumProfitsGroup> MinimumProfitsGroups { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OOMinimumProfitsGroup> OOMinimumProfitsGroups { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OOPercentageProfitsGroup> OOPercentageProfitsGroups { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MainProductSupplier> MainProductSuppliers { get; set; }
    }
}