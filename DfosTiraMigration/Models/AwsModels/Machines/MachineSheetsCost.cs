namespace DfosTiraMigration.Models.AwsModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MachineSheetsCost
    {
        public int ID { get; set; }

        public int SheetsTypeId { get; set; }

        public int PriceListsMachineId { get; set; }

        public bool CLSwitch { get; set; }

        public bool OCSwitch { get; set; }

        public bool TCSwitch { get; set; }

        public bool BCSwitch { get; set; }

        public double? CLCost { get; set; }

        public double? OCCost { get; set; }

        public double? TCCost { get; set; }

        public double? BCCost { get; set; }

        public double? CLSpeed { get; set; }

        public double? OCSpeed { get; set; }

        public double? TCSpeed { get; set; }

        public double? BCSpeed { get; set; }

        public virtual PriceListsMachine PriceListsMachine { get; set; }

        public virtual SheetsType SheetsType { get; set; }
    }
}
