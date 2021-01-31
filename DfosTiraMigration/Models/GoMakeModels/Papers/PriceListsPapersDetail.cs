namespace DfosTiraMigration.Models.GoMakeModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PriceListsPapersDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PriceListsPapersDetail()
        {
            PriceListsPaperDetailsMachines = new HashSet<PriceListsPaperDetailsMachine>();
        }

        public Guid ID { get; set; }

        public Guid PriceListsPaperId { get; set; }

        [Required]
        public string Value { get; set; }

        public double? A4 { get; set; }

        public double? A3 { get; set; }

        [Column("33/48.4")]
        public double? C33_48_4 { get; set; }

        [Column("50/70")]
        public double? C50_70 { get; set; }

        [Column("100/70")]
        public double? C100_70 { get; set; }

        [Column("33/86.7")]
        public double? C33_86_7 { get; set; }

        [Column("33/100")]
        public double? C33_100 { get; set; }

        public double? Thickness { get; set; }

        public double? Weight { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PriceListsPaperDetailsMachine> PriceListsPaperDetailsMachines { get; set; }

        public virtual PriceListsPaper PriceListsPaper { get; set; }
    }
}
