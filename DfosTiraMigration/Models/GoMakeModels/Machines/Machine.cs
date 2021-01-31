namespace DfosTiraMigration.Models.GoMakeModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Machine
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Machine()
        {
            PriceListsMachines = new HashSet<PriceListsMachine>();
        }

        public Guid ID { get; set; }

        [Required]
        public string Name { get; set; }

        public Guid PrintHouseId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PriceListsMachine> PriceListsMachines { get; set; }
    }
}
