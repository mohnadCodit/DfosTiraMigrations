using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.ElinerModels.Helper
{
    public class SpecialColorHelper
    {
        public SpecialColorHelper()
        {
            Quantity = 0;
            GoldLayers = 0;
            WhiteLayers = 0;
            BackgroundLayers = 0;
            TransparentLayers = 0;
            MetalicGrayLayers = 0;

            GoldPercent = "עד 10%";
            WhitePercent = "עד 10%";
            BackgroundPercent = "עד 10%";
            TransparentPercent = "עד 10%";
            MetalicGrayPercent = "עד 10%";

            FirstRowName = "מספר שכבות";
            SecondRowName = "אחוז פריסה";
        }

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

        public string FirstRowName { get; set; }

        public string SecondRowName { get; set; }
    }
}