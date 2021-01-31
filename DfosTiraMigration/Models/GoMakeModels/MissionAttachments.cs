using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.GoMakeModels
{
    public class MissionAttachments
    {
        public int ID { get; set; }

        [Required]
        public int MissionID { get; set; }

        [Required]
        public string FilePath { get; set; }

        public virtual BoardMissions BoardMissions { get; set; }
    }
}