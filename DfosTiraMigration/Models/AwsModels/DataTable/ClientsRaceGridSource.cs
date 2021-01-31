﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.AwsModels.DataTable
{
    public class ClientsRaceGridSource
    {
        public int clientId { get; set; }

        public string client { get; set; }

        public int orders { get; set; }

        public double bid { get; set; }

        public double digital { get; set; }

        public double envelopes { get; set; }

        public double notepad { get; set; }

        public double printing { get; set; }

        public double books { get; set; }

        public double shelfProducts { get; set; }

        public double products { get; set; }

        public double total { get; set; }
    }
}