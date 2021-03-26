using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.ElinerModels
{
    public class ClientType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ClientType()
        {
            PercentageProfitsGroups = new HashSet<PercentageProfitsGroup>();
            OOPercentageProfitsGroups = new HashSet<OOPercentageProfitsGroup>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public int IdenticalItemsDiscountId { get; set; }

        public virtual IdenticalItemsDiscounts IdenticalItemsDiscount { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PercentageProfitsGroup> PercentageProfitsGroups { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OOPercentageProfitsGroup> OOPercentageProfitsGroups { get; set; }
    }
}