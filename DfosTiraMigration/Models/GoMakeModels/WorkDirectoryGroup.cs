using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.GoMakeModels
{
    public class WorkDirectoryGroup
    {
        public Guid ID { get; set; }

        public string Name { get; set; }

        public Guid PrintHouseId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WorkDirectory> WorkDirectories { get; set; }
    }
}