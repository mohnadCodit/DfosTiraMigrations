using DfosTiraMigration.Models.ElinerModels.Products;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DfosTiraMigration.Models.ElinerModels
{
    public class BoardRows
    {

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BoardRows()
        {
            BoardMissions = new HashSet<BoardMissions>();
            SubProducts = new HashSet<SubProduct>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public int BoardID { get; set; }
        public int Order { get; set; } = 1;
        public Boards Board { get; set; }
        public bool IsActive { get; set; } = true;
        [NotMapped]
        public bool IsDeleted { get; set; } = false;
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BoardMissions> BoardMissions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubProduct> SubProducts { get; set; }
    }
}