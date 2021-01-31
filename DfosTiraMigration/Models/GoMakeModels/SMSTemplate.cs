namespace DfosTiraMigration.Models.GoMakeModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SMSTemplate
    {
        public Guid ID { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Text { get; set; }

        public Guid PrintHouseId { get; set; }

        public int TemplateTypeId { get; set; }
    }
}
