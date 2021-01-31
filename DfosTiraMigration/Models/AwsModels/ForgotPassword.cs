namespace DfosTiraMigration.Models.AwsModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ForgotPassword")]
    public partial class ForgotPassword
    {
        public int ID { get; set; }

        public int UserId { get; set; }

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