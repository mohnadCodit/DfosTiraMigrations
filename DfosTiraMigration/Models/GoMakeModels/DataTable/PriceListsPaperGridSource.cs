﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.GoMakeModels.DataTable
{
    public class PriceListsPaperGridSource
    {
        public Guid ID { get; set; }

        public Guid PriceListId { get; set; }

        public Guid PaperId { get; set; }

        public PaperGridSource Paper { get; set; }

        public List<PriceListsPapersDetailGridSource> PriceListsPapersDetails { get; set; }
    }

    public class PriceListsPapersDetailGridSource
    {
        public Guid ID { get; set; }

        public Guid PriceListsPaperId { get; set; }

        public string Value { get; set; }

        public double? A4 { get; set; }

        public double? A3 { get; set; }

        public double? C33_48_4 { get; set; }

        public double? C50_70 { get; set; }

        public double? C100_70 { get; set; }

        public double? C33_86_7 { get; set; }

        public double? C33_100 { get; set; }

        public double? Thickness { get; set; }

        public double? Weight { get; set; }

        public List<PriceListsPaperDetailsMachineGridSource> PriceListsPaperDetailsMachines { get; set; }
    }

    public class PaperGridSource
    {
        public Guid ID { get; set; }

        public string Name { get; set; }
    }

    public class PriceListsPaperDetailsMachineGridSource
    {
        public Guid ID { get; set; }

        public Guid PriceListsPapersDetailsId { get; set; }

        public Guid PriceListMachineId { get; set; }

        public double? Value { get; set; }
    }
}