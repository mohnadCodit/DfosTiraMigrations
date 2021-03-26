namespace DfosTiraMigration.Models.ElinerModels
{
    using DfosTiraMigration.Models.ElinerModels.Products;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OOPercentageProfitsGroup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OOPercentageProfitsGroup()
        {
            OOPercentageProfits = new HashSet<OOPercentageProfit>();
        }

        public int ID { get; set; }

        public int? PriceListId { get; set; }

        public int ClientTypeId { get; set; }

        public int? MainProductId { get; set; }

        public virtual ClientType ClientType { get; set; }

        public virtual MainProduct MainProduct { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OOPercentageProfit> OOPercentageProfits { get; set; }

        public virtual PriceList PriceList { get; set; }
    }
}
