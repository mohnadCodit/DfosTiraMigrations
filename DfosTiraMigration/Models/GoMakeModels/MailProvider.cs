using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.GoMakeModels
{
    public class MailProvider
    {
        public Guid ID { get; set; }
        public string Provider { get; set; }
        public int Port { get; set; }
        public string Host { get; set; }
        public Guid? PrintHouseId { get; set; }
    }
}