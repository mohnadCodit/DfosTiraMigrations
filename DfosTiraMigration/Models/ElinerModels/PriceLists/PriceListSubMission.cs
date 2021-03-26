using DfosTiraMigration.Models.ElinerModels.PriceListsModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.ElinerModels.PriceLists
{
    public class PriceListSubMission
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PriceListSubMission()
        {
           
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }
        public int? PricelistParameterId { get; set; }
        public int PriceListId { get; set; }
        public int BoardId { get; set; }
        public bool isActive { get; set; }
        public virtual Boards Board { get; set; }
        public virtual PriceListParameter PriceListParameter { get; set; }
        public virtual PriceList PriceList { get; set; }
        public virtual ICollection<SubMissionBoard> SubMissionBoards { get; set; }

        [NotMapped]
        public string ParameterName { get; set; }
        [NotMapped]
        public string BoardName { get; set; }
        [NotMapped]
        public bool IsOO { get; set; }
        [NotMapped]
        public bool IsReady { get; set; }
        [NotMapped]
        public int ParameterStatusId { get; set; }
        [NotMapped]
        public List<int> BoardsIds { get; set; }

    }
}