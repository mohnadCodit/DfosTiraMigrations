using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.GoMakeModels.Helper
{
    public class OOParametersDetails
    {
        public List<Guid> ooSubMissionsIds { get; set; }

        public List<double> ooSubMissionsCosts { get; set; }

        public List<Guid> ooSubMissionsPartnersIds { get; set; }
    }
}