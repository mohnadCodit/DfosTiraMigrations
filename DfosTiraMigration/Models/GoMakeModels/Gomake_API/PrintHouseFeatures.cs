using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.GoMakeModels.Gomake_API
{
    public class PrintHouseFeatures
    {
        public Guid Id { get; set; }
        public bool IsActive { get; set; }
        public Guid FeatureId { get; set; }
        public string FeatureName { get; set; }
        public Guid PrintHouseId { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}