using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.GoMakeModels.Searches
{
    public class MachinesSearch
    {
        public Guid PriceListId { get; set; }

        public Guid? PriceListMachineId { get; set; }

        public string MachineName { get; set; }

        public string PriceListName { get; set; }
    }
}