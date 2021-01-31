using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.GoMakeModels.DataTable
{
    public class SubProductsParametersGridSource
    {
        public Guid ID { get; set; }

        public string Name { get; set; }

        public string OriginalValues { get; set; }

        public string Values { get; set; }

        public string PriceListDefaultValue { get; set; }

        public string DefaultValue { get; set; }

        public bool IsVisible { get; set; }

        public bool IsReadOnly { get; set; }
    }
}