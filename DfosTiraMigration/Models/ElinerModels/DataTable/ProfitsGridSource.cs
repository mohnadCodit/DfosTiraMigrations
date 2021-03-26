using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.ElinerModels.DataTable
{
    public class ProfitsGroupsGridSource
    {
        public float XPoint { get; set; }

        public List<ProfitsGridSource> profits { get; set; }
    }
    public class ProfitsGridSource
    {
        public int ID { get; set; }

        public float YPoint { get; set; }
    }
}