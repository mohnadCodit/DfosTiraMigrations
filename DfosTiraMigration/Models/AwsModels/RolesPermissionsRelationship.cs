using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.AwsModels
{
    [Table("RolesPermissionsRelationship")]
    public class RolesPermissionsRelationship
    {
        public int ID { get; set; }

        public int RoleId { get; set; }

        public int PermissionId { get; set; }


        //public virtual Role Role { get; set; }

        public virtual Permission Permission { get; set; }

        [NotMapped]
        public bool IsSelected { get; set; }
    }
}