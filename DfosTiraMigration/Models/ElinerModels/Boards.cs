﻿using DfosTiraMigration.Models.ElinerModels.BoardModels;
using DfosTiraMigration.Models.ElinerModels.PriceLists;
using DfosTiraMigration.Models.ElinerModels.PriceListsModels;
using DfosTiraMigration.Models.ElinerModels.Products;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DfosTiraMigration.Models.ElinerModels
{
    public class Boards
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Boards()
        {
            BoardRows = new HashSet<BoardRows>();
            BoardUsers = new HashSet<BoardUsers>();
            SubProducts = new HashSet<SubProduct>();
            BoardColumns = new HashSet<BoardColumns>();
            BoardMissions = new HashSet<BoardMissions>();
            BoardUserPermissions = new HashSet<BoardUserPermission>();
            //PriceListParametersBoards = new HashSet<PriceListParametersBoard>();
        }

        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public int Order { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BoardColumns> BoardColumns { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BoardRows> BoardRows { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BoardMissions> BoardMissions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BoardUsers> BoardUsers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BoardUserPermission> BoardUserPermissions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubProduct> SubProducts { get; set; }

       // [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<PriceListParametersBoard> PriceListParametersBoards { get; set; }
    }
}