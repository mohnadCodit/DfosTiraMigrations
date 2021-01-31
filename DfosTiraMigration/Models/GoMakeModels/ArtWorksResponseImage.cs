using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.GoMakeModels
{
    public class ArtWorksResponseImage
    {
        public Guid ID { get; set; }

        public Guid ArtworksId { get; set; }

        public string Path { get; set; }

        public virtual Artworks Artworks { get; set; }
    }
}