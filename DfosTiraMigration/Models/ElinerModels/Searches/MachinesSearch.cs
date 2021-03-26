using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.ElinerModels.Searches
{
    public class MachinesSearch
    {
        public int PriceListId { get; set; }

        public int? PriceListMachineId { get; set; }

        public string MachineName { get; set; }

        public string PriceListName { get; set; }
    }
}