using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.AwsModels.Logs
{
    public class BoardMissionsLog 
    {
        public int ID { get; set; }

        public int LogTypeId { get; set; }

        public int UserId { get; set; }

        public int BoardMissionId { get; set; }

        public DateTime CreationDate { get; set; }

        public string Description { get; set; }

        public int BoardId { get; set; }

        public int BoardRowId { get; set; }

        public int BoardColumnId { get; set; }

        public virtual User User { get; set; }

        public virtual BoardMissions BoardMission { get; set; }
    }
}