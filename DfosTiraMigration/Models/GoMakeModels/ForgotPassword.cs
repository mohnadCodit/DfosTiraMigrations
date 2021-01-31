namespace DfosTiraMigration.Models.GoMakeModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ForgotPassword")]
    public partial class ForgotPassword
    {
        public Guid ID { get; set; }

        public Guid UserId { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string VerificationCode { get; set; }

        public DateTime DateColumn { get; set; }
        [StringLength(50)]
        public string Password { get; set; }
        [StringLength(50)]
        public string ConfirmPassword { get; set; }
    }
}