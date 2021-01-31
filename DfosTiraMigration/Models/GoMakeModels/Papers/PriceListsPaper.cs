namespace DfosTiraMigration.Models.GoMakeModels
{
    using DfosTiraMigration.Models.GoMakeModels.PriceLists;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PriceListsPaper
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PriceListsPaper()
        {
            PriceListsPapersDetails = new HashSet<PriceListsPapersDetail>();
        }

        public Guid ID { get; set; }

        public Guid PriceListId { get; set; }

        public Guid PaperId { get; set; }

        public virtual Paper Paper { get; set; }

        public virtual PriceList PriceList { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PriceListsPapersDetail> PriceListsPapersDetails { get; set; }
    }
}
