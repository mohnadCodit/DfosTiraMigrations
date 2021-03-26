using DfosTiraMigration.Models.ElinerModels.PriceListsModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace DfosTiraMigration.Models.ElinerModels
{
    [Table("BidItemValueShtansim")]
    public class BidItemValueShtansim
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [ForeignKey("ShtansShape")]
        public int ShapeID { get; set; }

        public string RunningDirection { get; set; }

        public int Frames { get; set; }

        public double FrameHeight { get; set; }

        public int FrameRows { get; set; }

        public int PaperWidth { get; set; }

        public double Jump { get; set; }

        public string TemplateStatus { get; set; }

        public double StickerHeight { get; set; }

        public double StickerWidth { get; set; }

        public int Columns { get; set; }

        public int Rows { get; set; }

        public double ColumnsIntireSpace { get; set; }

        public double RowsIntireSpace { get; set; }

        public double PrintingWidth { get; set; }

        public double ARTWidth { get; set; }

        public double Margin { get; set; }

        public double PaperWidthCalc { get; set; }

        public int? ColumnsCalc { get; set; }

        public string Symbol { get; set; }

        public int? ImageID { get; set; }

        public string Notes { get; set; }

        public string ExtraName { get; set; }

        public int? Number { get; set; }

        public string StandingGraphics1 { get; set; }
        public string StandingGraphics2 { get; set; }
        public string StandingGraphics3 { get; set; }
        public string StandingGraphics4 { get; set; }

        public string LyingGraphics1 { get; set; }
        public string LyingGraphics2 { get; set; }
        public string LyingGraphics3 { get; set; }
        public string LyingGraphics4 { get; set; }

        public virtual Image Image { get; set; }

        public virtual ShtansShape ShtansShape { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BidItemValue> BidItemValues { get; set; }
    }
}