using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.ElinerModels.Searches
{
    public class SubProductsSearch
    {
        public int? id { get; set; }

        public int? priceListId { get; set; }

        public int? pageNumber { get; set; }

        public int? table_page_number { get; set; }

        public int? table_page_length { get; set; }
    }
}