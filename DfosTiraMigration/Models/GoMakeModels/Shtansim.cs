namespace DfosTiraMigration.Models.GoMakeModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using DfosTiraMigration.Models.GoMakeModels.PriceListsModels;

    [Table("Shtansim")]
    public partial class Shtansim
    {
        public Guid ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public int ShapeID { get; set; }

        public string RunningDirection { get; set; }

        public int Frames { get; set; }

        public double FrameHeight { get; set; }

        public int FrameRows { get; set; }

        public int PaperWidth { get; set; }

        public double Jump { get; set; }

        [Required]
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

        public Guid? ImageID { get; set; }

        public string Notes { get; set; }

        public string ExtraName { get; set; }

        public string KeyWords { get; set; }

        public Guid PrintHouseId { get; set; }

        public virtual Image Image { get; set; }

        [NotMapped]
        public string ShtansShapeName { get; set; }
    }
}
