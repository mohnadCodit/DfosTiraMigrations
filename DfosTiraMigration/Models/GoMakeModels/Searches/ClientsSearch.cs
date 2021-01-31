using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.GoMakeModels.Searches
{
    public class ClientsSearch
    {
        public Guid? clientTypeId { get; set; }
        public bool? isActive { get; set; }
        public bool? isCritical { get; set; }
    }
}