namespace DfosTiraMigration.Models.AwsModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ScriptFileLastAccess")]
    public partial class ScriptFileLastAccess
    {
        public int ID { get; set; }

        public DateTime DateOfLastAccess { get; set; }
    }
}
