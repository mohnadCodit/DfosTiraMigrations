﻿using DfosTiraMigration.Models.AwsModels.Products;
using System.Collections.Generic;

namespace DfosTiraMigration.Models.AwsModels
{
    public class BoardColumns
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BoardColumns()
        {
            BoardMissions = new HashSet<BoardMissions>();
            SubProducts = new HashSet<SubProduct>();
        }

        public int ID { get; set; }

        public string Name { get; set; }

        public int BoardID { get; set; }

        public int Tickets { get; set; } = 1;

        public Boards Board { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BoardMissions> BoardMissions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubProduct> SubProducts { get; set; }
    }
}