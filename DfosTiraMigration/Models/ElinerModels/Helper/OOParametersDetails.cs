using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.ElinerModels.Helper
{
    public class OOParametersDetails
    {
        public List<int> ooSubMissionsIds { get; set; }

        public List<double> ooSubMissionsCosts { get; set; }

        public List<int> ooSubMissionsPartnersIds { get; set; }
    }
}