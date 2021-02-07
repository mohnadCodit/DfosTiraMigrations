using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using DfosTiraMigration.Models.AwsModels.PriceListsModels;
using DfosTiraMigration.Models.AwsModels.Logs;

namespace DfosTiraMigration.Models.AwsModels
{
    public class BoardMissions
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BoardMissions()
        {
            BidMissionNotes = new HashSet<BidMissionNote>();
            BoardMissionsLogs = new HashSet<BoardMissionsLog>();
        }

        public int ID { get; set; }
        public string Number { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int BoardID { get; set; }
        public int ColumnID { get; set; }
        public int RowID { get; set; }
        public int? OrderItemID { get; set; }
        public int? SourceIdentity { get; set; }
        public DateTime? DueDate { get; set; }
        public bool isReady { get; set; }
        public bool isDynamic { get; set; }
        public int? Priority { get; set; }

        public virtual Boards Board { get; set; }
        public virtual OrderItem OrderItem { get; set; }
        [ForeignKey("RowID")]
        public virtual BoardRows BoardRow { get; set; }
        [ForeignKey("ColumnID")]
        public virtual BoardColumns BoardColumn { get; set; }

        [NotMapped]
        public List<OrderItemFile> OrderItemFiles { get; set; }
        [NotMapped]
        public int RelatedMissions { get; set; }
        //[NotMapped]
        //public int IsNotDynamicMissionsInOrder { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BidMissionNote> BidMissionNotes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BoardMissionsLog> BoardMissionsLogs { get; set; }
    }
}