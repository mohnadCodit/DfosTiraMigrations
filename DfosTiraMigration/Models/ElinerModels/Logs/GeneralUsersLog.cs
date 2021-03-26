using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.ElinerModels.Logs
{
    public class GeneralUsersLog
    {
        public int ID { get; set; }

        public int LogTypeId { get; set; }

        public int UserId { get; set; }

        public DateTime CreationDate { get; set; }

        public string Description { get; set; }

        public virtual LogType LogType { get; set; }

        public virtual User User { get; set; }

    }
}