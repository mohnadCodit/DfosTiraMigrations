namespace DfosTiraMigration.Models.AwsModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BusinessPartnerContact
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        public string Mail { get; set; }

        [Required]
        public string Phone { get; set; }

        public bool IsPrimary { get; set; }

        public int BusinessPartnerId { get; set; }

        public virtual BusinessPartner BusinessPartner { get; set; }
    }
}
