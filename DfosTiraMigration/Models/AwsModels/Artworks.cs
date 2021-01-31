using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.AwsModels
{
    public class Artworks
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Artworks()
        {
            ArtWorksResponseImages = new HashSet<ArtWorksResponseImage>();
        }

        public int ID { get; set; }

        public Guid? GroupArtworksKey { get; set; }

        [Required]
        public string FileName { get; set; }

        [Required]
        public string FilePath { get; set; }

        public bool IsApproved { get; set; } = false;

        public bool IsReplied { get; set; } = false;

        public string Notes { get; set; }

        public virtual GroupArtworks GroupArtworks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ArtWorksResponseImage> ArtWorksResponseImages { get; set; }

        [NotMapped]
        public List<string> ImagesPaths { get; set; }
    }
}