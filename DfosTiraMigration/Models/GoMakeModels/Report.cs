namespace DfosTiraMigration.Models.GoMakeModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Report
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Report()
        {
            ReportsRelations = new HashSet<ReportsRelation>();
            ID = Guid.NewGuid();
        }

        public Guid ID { get; set; }

        public Guid EmployeeID { get; set; }

        public Guid CustomerID { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        [Required]
        [StringLength(50)]
        public string OrderNumber { get; set; }

        [StringLength(100)]
        public string Notes { get; set; }

        public virtual Client Customer { get; set; }

        public virtual Employee Employee { get; set; }

        public Guid PrintHouseId { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReportsRelation> ReportsRelations { get; set; }
    }
}
