namespace DfosTiraMigration.Models.ElinerModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SMSTemplate
    {
        public int ID { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Text { get; set; }
    }
}
