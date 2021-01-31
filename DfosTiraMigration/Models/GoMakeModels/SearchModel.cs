using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.GoMakeModels
{
    public class SearchModel
    {
        public Guid? employeeId { get; set; }
        public Guid? clientId { get; set; }
        public string dateRange { get; set; }
    }
}