﻿using DfosTiraMigration.Models.GoMakeModels.DataTable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.GoMakeModels.Filters
{
    public class ORMissionsFilter
    {
        public int totalResultsCount { get; set; }

        public IList<BoardMissionGridSource> data { get; set; }

        public double totalComissions { get; set; }

        public double totalPrice { get; set; }

        public double totalOOCost { get; set; }

    }
}