using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.AwsModels.DataTable
{
    public class PriceListsMachineGridSource
    {
        public int ID { get; set; }

        public int PriceListId { get; set; }

        public int MachineId { get; set; }

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

        public SheetsTypeGridSource SheetsType { get; set; }
    }

    public class MachineGridSource
    {
        public int ID { get; set; }

        public string Name { get; set; }
    }

    public class SheetsTypeGridSource
    {
        public int ID { get; set; }

        public string Name { get; set; }
    }

}