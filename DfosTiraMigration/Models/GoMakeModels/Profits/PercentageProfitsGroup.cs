namespace DfosTiraMigration.Models.GoMakeModels
{
    using DfosTiraMigration.Models.GoMakeModels.Products;
    using System;
    using System.Collections.Generic;

    public partial class PercentageProfitsGroup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PercentageProfitsGroup()
        {
            PercentageProfits = new HashSet<PercentageProfit>();
        }

        public Guid ID { get; set; }

        public Guid? PriceListId { get; set; }

        public Guid ClientTypeId { get; set; }

        public Guid? MainProductId { get; set; }

        public virtual ClientType ClientType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PercentageProfit> PercentageProfits { get; set; }

        public virtual PriceList PriceList { get; set; }

        public virtual MainProduct MainProduct { get; set; }
    }
}
