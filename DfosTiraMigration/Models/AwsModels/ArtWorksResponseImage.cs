using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.AwsModels
{
    public class ArtWorksResponseImage
    {
        public int ID { get; set; }

        public int ArtworksId { get; set; }

        public string Path { get; set; }

        public virtual Artworks Artworks { get; set; }
    }
}