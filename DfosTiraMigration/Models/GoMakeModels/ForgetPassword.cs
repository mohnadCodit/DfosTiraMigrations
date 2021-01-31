using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.GoMakeModels
{
    public class ForgetPassword
    {
        [EmailAddress]
        [Required(ErrorMessage = "*חובה להזין דואר אלקטרוני")]
        public string Email { set; get; }
    }
}