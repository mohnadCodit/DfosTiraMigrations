using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.GoMakeModels.Logs
{
    public class GeneralUsersLog
    {
        public Guid ID { get; set; }

        public int LogTypeId { get; set; }

        public Guid UserId { get; set; }

        public DateTime CreationDate { get; set; }

        public string Description { get; set; }

        public virtual User User { get; set; }

    }
}