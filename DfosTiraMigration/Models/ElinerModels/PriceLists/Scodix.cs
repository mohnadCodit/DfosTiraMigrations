namespace DfosTiraMigration.Models.ElinerModels.PriceListsModels
{
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Scodix")]
    public partial class Scodix
    {
        public int ID { get; set; }

        public int? DigitalItemValueId { get; set; }

        public int? IntireColumnId { get; set; }

        public int? ScodixItemValueId { get; set; }

        public int? GlassesItemValueId { get; set; }

        public int? CoverId { get; set; }

        public string FirstFoil { get; set; }

        public double? FirstFoilWidth { get; set; } = 0.00;

        public double? FirstFoilHeight { get; set; } = 0.00;

        public string FirstFoilPercent { get; set; }

        public string SecondFoil { get; set; }

        public double? SecondFoilWidth { get; set; } = 0.00;

        public double? SecondFoilHeight { get; set; } = 0.00;

        public string SecondFoilPercent { get; set; }

        public string ScodixType { get; set; }

        public double? ScodixWidth { get; set; } = 0.00;

        public double? ScodixHeight { get; set; } = 0.00;

        public string ScodixPercent { get; set; }

        public virtual Cover Cover { get; set; }

        public virtual DigitalItemValue DigitalItemValue { get; set; }

        public virtual IntireColumn IntireColumn { get; set; }

        public virtual ScodixItemValue ScodixItemValue { get; set; }

        public virtual GlassesItemValue GlassesItemValue { get; set; }

        [NotMapped]
        public int index { get; set; }
        [NotMapped]
        public string parentId { get; set; }
        [NotMapped]
        public string parentName { get; set; }
    }
}
