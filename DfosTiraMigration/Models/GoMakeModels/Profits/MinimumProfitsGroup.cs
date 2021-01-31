namespace DfosTiraMigration.Models.GoMakeModels
{
    using DfosTiraMigration.Models.GoMakeModels.Products;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MinimumProfitsGroup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MinimumProfitsGroup()
        {
            MinimumProfits = new HashSet<MinimumProfit>();
        }

        public Guid ID { get; set; }

        public Guid? PriceListId { get; set; }

        public Guid? MainProductId { get; set; }

        public virtual MainProduct MainProduct { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MinimumProfit> MinimumProfits { get; set; }

        public virtual PriceList PriceList { get; set; }
    }
}
