using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.ElinerModels.PriceLists
{
    public class SubMissionBoard
    {
        public int Id { get; set; }
        public int PriceListSubMissionId { get; set; }
        public int BoardId { get; set; }
        public bool isActive { get; set; }
        public virtual Boards Board { get; set; }
    }
}