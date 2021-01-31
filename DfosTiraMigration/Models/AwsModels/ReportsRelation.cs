namespace DfosTiraMigration.Models.AwsModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ReportsRelation
    {
        public int ID { get; set; }

        public int ReportId { get; set; }

        public TimeSpan From { get; set; }

        public TimeSpan To { get; set; }

        //public virtual Report Report { get; set; }
    }
}
