using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.AwsModels.DataTable
{
    public class UserGridSource
    {
        public int ID { get; set; }

        public string username { get; set; }

        public string Password { get; set; }

        public string name { get; set; }

        public string nickname { get; set; }

        public string email { get; set; }

        public string role { get; set; }

        public bool isActive { get; set; }

        public int? customerId { get; set; }
    }
}