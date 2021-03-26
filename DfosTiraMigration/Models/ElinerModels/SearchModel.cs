using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.ElinerModels
{
    public class SearchModel
    {
        public int? employeeId { get; set; }
        public int? clientId { get; set; }
        public string dateRange { get; set; }
    }
}