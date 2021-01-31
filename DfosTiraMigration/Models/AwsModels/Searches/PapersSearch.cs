using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.AwsModels.Searches
{
    public class PapersSearch
    {
        public int PriceListId { get; set; }

        public int? PriceListPaperId { get; set; }

        public string PaperName { get; set; }

        public string PriceListName { get; set; }

        public int MachinesNumber { get; set; }
    }
}