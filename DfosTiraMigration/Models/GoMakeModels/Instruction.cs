using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.GoMakeModels
{
    public class Instruction
    {
        public Guid ID { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public Guid InstructionsGroupId { get; set; }

        public virtual InstructionsGroup InstructionsGroup { get; set; }
    }
}