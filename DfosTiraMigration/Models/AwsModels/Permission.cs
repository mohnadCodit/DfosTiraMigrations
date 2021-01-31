using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.AwsModels
{
    public class Permission
    {
        public Permission()
        {
            RolesPermissionsRelationships = new HashSet<RolesPermissionsRelationship>();
        }

        public int ID { get; set; }

        public string Description { get; set; }

        public int Order { get; set; }

        public virtual ICollection<RolesPermissionsRelationship> RolesPermissionsRelationships { get; set; }
    }
}