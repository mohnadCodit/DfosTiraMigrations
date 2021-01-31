using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.AwsModels
{
    public class QnapResponseModel
    {
        public int status { get; set; }
        public string build { get; set; }
        public string version { get; set; }
        public string success { get; set; }
    }
}