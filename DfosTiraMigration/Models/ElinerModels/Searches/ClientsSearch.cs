using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.ElinerModels.Searches
{
    public class ClientsSearch
    {
        public string clientTypeId { get; set; }
        public bool? isActive { get; set; }
        public bool? isCritical { get; set; }
    }
}