using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.ElinerModels
{
    public class MailProvider
    {
        public int ID { get; set; }
        public string Provider { get; set; }
        public int Port { get; set; }
        public string Host { get; set; }
    }
}