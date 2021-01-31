using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.GoMakeModels
{
    public class Permission
    {
        public Permission()
        {
            RolesPermissionsRelationships = new HashSet<RolesPermissionsRelationship>();
        }

        public Guid ID { get; set; }

        public string Description { get; set; }

        public int Order { get; set; }

        public Guid PermissionsGroupId { get; set; }

        public Guid? RelatedToFeatureId { get; set; }
        public virtual ICollection<RolesPermissionsRelationship> RolesPermissionsRelationships { get; set; }
    }
}