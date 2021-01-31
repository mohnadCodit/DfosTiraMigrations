using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.GoMakeModels.Searches
{
    public class SubProductsSearch
    {
        public Guid? id { get; set; }

        public int? priceListType { get; set; }

        public int? pageNumber { get; set; }

        public int? table_page_number { get; set; }

        public int? table_page_length { get; set; }
    }
}