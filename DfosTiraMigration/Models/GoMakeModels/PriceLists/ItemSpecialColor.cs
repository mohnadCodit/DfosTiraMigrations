using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.GoMakeModels.PriceListsModels
{
    public class ItemSpecialColor
    {

        public Guid ID { get; set; }

        public int GoldLayers { get; set; }

        public int MetalicGrayLayers { get; set; }

        public int WhiteLayers { get; set; }

        public int TransparentLayers { get; set; }

        public int BackgroundLayers { get; set; }

        public string GoldPercent { get; set; }

        public string MetalicGrayPercent { get; set; }

        public string WhitePercent { get; set; }

        public string TransparentPercent { get; set; }

        public string BackgroundPercent { get; set; }

        public int? Quantity { get; set; }

        public Guid? DigitalPriceListID { get; set; }

        [ForeignKey("EnvelopesItemValue")]
        public Guid? EnvelopesPriceListID { get; set; }

        public Guid? IntireColumnId { get; set; }

        public Guid? CoverId { get; set; }

        public virtual Cover Cover { get; set; }

        public virtual DigitalItemValue DigitalItemValue { get; set; }

        public virtual EnvelopesItemValue EnvelopesItemValue { get; set; }

        public virtual IntireColumn IntireColumn { get; set; }

        [NotMapped]
        public string parentId { get; set; }
        [NotMapped]
        public string parentName { get; set; }
        [NotMapped]
        public int index { get; set; }
    }
}