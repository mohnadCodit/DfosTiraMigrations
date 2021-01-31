using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.AwsModels.DataTable
{
    public class SubProductsParametersGridSource
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string OriginalValues { get; set; }

        public string Values { get; set; }

        public string PriceListDefaultValue { get; set; }

        public string DefaultValue { get; set; }

        public bool IsVisible { get; set; }
    }
}