using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.ElinerModels
{
    [Table("WorkDirectory")]
    public class WorkDirectory
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int WorkDirectoryGroupId { get; set; }

        public virtual WorkDirectoryGroup WorkDirectoryGroup { get; set; }
    }
}