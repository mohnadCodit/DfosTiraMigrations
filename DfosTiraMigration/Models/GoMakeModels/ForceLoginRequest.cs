using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.GoMakeModels
{
    public class ForceLoginRequest
    {
        [Key]
        public Guid Token { get; set; }
        public Guid UserId { get; set; }
        public string IP { get; set; }
    }
}