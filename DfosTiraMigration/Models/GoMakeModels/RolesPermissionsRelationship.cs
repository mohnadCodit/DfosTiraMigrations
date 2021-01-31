using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.GoMakeModels
{
    [Table("RolesPermissionsRelationship")]
    public class RolesPermissionsRelationship
    {
        public Guid ID { get; set; }

        public Guid RoleId { get; set; }

        public Guid PermissionId { get; set; }


        //public virtual Role Role { get; set; }

        public virtual Permission Permission { get; set; }

        [NotMapped]
        public bool IsSelected { get; set; }
    }
}