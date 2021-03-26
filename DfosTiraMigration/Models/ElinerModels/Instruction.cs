using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.ElinerModels
{
    public class Instruction
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public int InstructionsGroupId { get; set; }

        public virtual InstructionsGroup InstructionsGroup { get; set; }
    }
}