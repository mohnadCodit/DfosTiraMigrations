namespace DfosTiraMigration.Models.ElinerModels
{
    using DfosTiraMigration.Models.ElinerModels.Products;
    using System.Collections.Generic;

    public partial class PercentageProfitsGroup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PercentageProfitsGroup()
        {
            PercentageProfits = new HashSet<PercentageProfit>();
        }

        public int ID { get; set; }

        public int? PriceListId { get; set; }

        public int ClientTypeId { get; set; }

        public int? MainProductId { get; set; }

        public virtual ClientType ClientType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PercentageProfit> PercentageProfits { get; set; }

        public virtual PriceList PriceList { get; set; }

        public virtual MainProduct MainProduct { get; set; }
    }
}
