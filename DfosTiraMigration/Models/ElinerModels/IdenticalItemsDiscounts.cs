using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.ElinerModels
{
    public class IdenticalItemsDiscounts
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IdenticalItemsDiscounts()
        {
            ClientTypes = new HashSet<ClientType>();
        }

        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientType> ClientTypes { get; set; }
    }
}