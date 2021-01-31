namespace DfosTiraMigration.Models.AwsModels
{
    using DfosTiraMigration.Models.AwsModels.Products;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OOMinimumProfitsGroup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OOMinimumProfitsGroup()
        {
            OOMinimumProfits = new HashSet<OOMinimumProfit>();
        }

        public int ID { get; set; }

        public int? PriceListId { get; set; }

        public int? MainProductId { get; set; }

        public virtual MainProduct MainProduct { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OOMinimumProfit> OOMinimumProfits { get; set; }

        public virtual PriceList PriceList { get; set; }
    }
}
