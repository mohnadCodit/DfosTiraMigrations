namespace DfosTiraMigration.Models.GoMakeModels
{
    using DfosTiraMigration.Models.GoMakeModels.PriceLists;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class PriceList
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PriceList()
        {
            MinimumProfitsGroups = new HashSet<MinimumProfitsGroup>();
            PercentageProfitsGroups = new HashSet<PercentageProfitsGroup>();
            OOMinimumProfitsGroups = new HashSet<OOMinimumProfitsGroup>();
            OOPercentageProfitsGroups = new HashSet<OOPercentageProfitsGroup>();
            PriceListParameters = new HashSet<PriceListParameter>();
            PriceListsMachines = new HashSet<PriceListsMachine>();
            PriceListsPapers = new HashSet<PriceListsPaper>();
        }

        public Guid ID { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        public double OOCost { get; set; }

        public bool IsActive { get; set; }

        public string SheetId { get; set; }

        public int PriceListType { get; set; }

        public Guid PrintHouseId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PercentageProfitsGroup> PercentageProfitsGroups { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PriceListParameter> PriceListParameters { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PriceListsMachine> PriceListsMachines { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PriceListsPaper> PriceListsPapers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MinimumProfitsGroup> MinimumProfitsGroups { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OOMinimumProfitsGroup> OOMinimumProfitsGroups { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OOPercentageProfitsGroup> OOPercentageProfitsGroups { get; set; }
    }
}
