using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.ElinerModels.DataTable
{
    public class LogsGridSource
    {
        public DateTime CreationDate { get; set; }

        public string Number { get; set; }

        public string Username { get; set; }

        public string LogType { get; set; }

        public string Description { get; set; }

    }
}