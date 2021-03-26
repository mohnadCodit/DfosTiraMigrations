using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.GoMakeModels
{
    public class ClientType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ClientType()
        {
            PercentageProfitsGroups = new HashSet<PercentageProfitsGroup>();
            OOPercentageProfitsGroups = new HashSet<OOPercentageProfitsGroup>();
        }

        public Guid ID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public int IdenticalItemsDiscountId { get; set; }

        public Guid PrintHouseId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PercentageProfitsGroup> PercentageProfitsGroups { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OOPercentageProfitsGroup> OOPercentageProfitsGroups { get; set; }

        public int? DID { get; set; }
    }
}