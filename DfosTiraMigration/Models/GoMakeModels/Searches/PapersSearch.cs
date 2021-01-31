using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.GoMakeModels.Searches
{
    public class PapersSearch
    {
        public Guid PriceListId { get; set; }

        public Guid? PriceListPaperId { get; set; }

        public string PaperName { get; set; }

        public string PriceListName { get; set; }

        public int MachinesNumber { get; set; }
    }
}