﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.AwsModels
{
    public class BidMissionNote
    {
        public int ID { get; set; }

        public int BoardMissionID { get; set; }

        public bool C { get; set; }

        public bool M { get; set; }

        public bool Y { get; set; }

        public bool K { get; set; }

        public bool EPM { get; set; }

        public bool White { get; set; }

        public bool HP { get; set; }

        public string GeneralNotes { get; set; }

        public string ShtansNotes { get; set; }

        public virtual BoardMissions BoardMission { get; set; }



    }
}