using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.ElinerModels.BoardModels
{
    public class BoardPermission
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BoardPermission()
        {
            //BoardUserPermissions = new HashSet<BoardUserPermission>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public int Order { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<BoardUserPermission> BoardUserPermissions { get; set; }
    }
}