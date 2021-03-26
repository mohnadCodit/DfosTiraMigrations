using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.GoMakeModels.Logs
{
    public class BoardMissionsLog 
    {
        public BoardMissionsLog()
        {
            ID = Guid.NewGuid();
        }
        public Guid ID { get; set; }

        public int LogTypeId { get; set; }

        public Guid UserId { get; set; }

        public Guid BoardMissionId { get; set; }

        public DateTime CreationDate { get; set; }

        public string Description { get; set; }

        public Guid BoardId { get; set; }

        public Guid BoardRowId { get; set; }

        public Guid BoardColumnId { get; set; }

        public Guid PrintHouseId { get; set; }
        public virtual User User { get; set; }

        public virtual BoardMissions BoardMission { get; set; }

        public int? DID { get; set; }
    }
}