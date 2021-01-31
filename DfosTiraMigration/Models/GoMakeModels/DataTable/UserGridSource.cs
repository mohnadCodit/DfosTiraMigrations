using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.GoMakeModels.DataTable
{
    public class UserGridSource
    {
        public Guid ID { get; set; }

        public string username { get; set; }

        public string Password { get; set; }

        public string name { get; set; }

        public string nickname { get; set; }

        public string email { get; set; }

        public string role { get; set; }

        public bool isActive { get; set; }

        public Guid? customerId { get; set; }

        public bool isInternalClient { get; set; }
    }
}