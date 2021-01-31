namespace DfosTiraMigration.Models.GoMakeModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RelatedFile
    {
        public Guid ID { get; set; }

        public Guid ArtWorkID { get; set; }

        [Required]
        public string ImageName { get; set; }

        [Required]
        public string FileContent { get; set; }
    }
}
