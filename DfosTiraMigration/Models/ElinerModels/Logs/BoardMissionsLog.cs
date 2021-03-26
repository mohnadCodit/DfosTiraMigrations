using System;
using System.Collections.Generic;


namespace DfosTiraMigration.Models.ElinerModels.Logs
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

        public virtual LogType LogType { get; set; }

        public virtual BoardMissions BoardMission { get; set; }
    }
}