namespace DfosTiraMigration.Models.AwsModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RelatedFile
    {
        public int ID { get; set; }

        public int ArtWorkID { get; set; }

        [Required]
        public string ImageName { get; set; }

        [Required]
        public string FileContent { get; set; }
    }
}
