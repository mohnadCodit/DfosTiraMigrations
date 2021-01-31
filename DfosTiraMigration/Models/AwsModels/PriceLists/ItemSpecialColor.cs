using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.AwsModels.PriceListsModels
{
    public class ItemSpecialColor
    {

        public int ID { get; set; }

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

        public bool isCover { get; set; }

        public int? Quantity { get; set; }

        public int? DigitalPriceListID { get; set; }

        public int? BooksPriceListID { get; set; }

        public int? EnvelopesPriceListID { get; set; }


        public virtual BooksItemValue BooksPriceList { get; set; }
        public virtual DigitalItemValue DigitalPriceList { get; set; }
        public virtual EnvelopesItemValue EnvelopesPriceList { get; set; }

    }
}