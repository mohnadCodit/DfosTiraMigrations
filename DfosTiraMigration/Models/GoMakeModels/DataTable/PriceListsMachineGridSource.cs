using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.GoMakeModels.DataTable
{
    public class PriceListsMachineGridSource
    {
        public Guid ID { get; set; }

        public Guid PriceListId { get; set; }

        public Guid MachineId { get; set; }

        public double? Productivity { get; set; }

        public double? MachineCost { get; set; }

        public double? LifeSpanYears { get; set; }

        public double? MonthlyCost { get; set; }

        public double? MachineHourCost { get; set; }

        public double? AgentHourCost { get; set; }

        public List<MachineSheetsCostsGridSource> MachineSheetsCosts { get; set; }

        public MachineGridSource Machine { get; set; }

    }

    public class MachineSheetsCostsGridSource
    {
        public Guid ID { get; set; }

        public Guid SheetsTypeId { get; set; }

        public Guid PriceListsMachineId { get; set; }

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

        public SheetsTypeGridSource SheetsType { get; set; }
    }

    public class MachineGridSource
    {
        public Guid ID { get; set; }

        public string Name { get; set; }
    }

    public class SheetsTypeGridSource
    {
        public Guid ID { get; set; }

        public string Name { get; set; }
    }

}