using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DfosTiraMigration.Models.GoMakeModels
{
    public class InstructionsGroup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InstructionsGroup()
        {
            Instructions = new HashSet<Instruction>();
        }

        public Guid ID { get; set; }

        [Required]
        public string Name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Instruction> Instructions { get; set; }
    }
}