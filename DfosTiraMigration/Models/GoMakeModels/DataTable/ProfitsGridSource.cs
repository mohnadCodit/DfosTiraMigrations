using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.GoMakeModels.DataTable
{
    public class ProfitsGroupsGridSource
    {
        public float XPoint { get; set; }

        public List<ProfitsGridSource> profits { get; set; }
    }
    public class ProfitsGridSource
    {
        public Guid ID { get; set; }

        public float YPoint { get; set; }
    }
}