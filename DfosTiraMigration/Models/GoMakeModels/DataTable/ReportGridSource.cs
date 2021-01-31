using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.GoMakeModels.DataTable
{
    public class ReportGridSource
    {
        public Guid ID { get; set; }

        public DateTime Date { get; set; }

        public string EmployeeName { get; set; }

        public string OrderNumber { get; set; }

        public string CustomerName { get; set; }

        public string Notes { get; set; }

        public string ReportHours { get; set; }
    }
}