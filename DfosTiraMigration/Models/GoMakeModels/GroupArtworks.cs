using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.GoMakeModels
{
    public class GroupArtworks
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GroupArtworks()
        {
            Artworks = new HashSet<Artworks>();
        }

        [Key]
        public Guid GroupKey { get; set; }

        public DateTime Created { get; set; } = DateTime.Now;

        public Guid? ClientID { get; set; }

        public string Phone { get; set; }

        public string Mail { get; set; }

        public string OrderNumber { get; set; }

        public string Message { get; set; }

        public string ClientNotes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Artworks> Artworks { get; set; }
    }
}