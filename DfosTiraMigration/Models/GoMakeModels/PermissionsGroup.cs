using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.GoMakeModels
{
    public class PermissionsGroup
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid? RelatedToFeatureId { get; set; }
        public virtual ICollection<Permission> Permissions { get; set; }
    }
}