using DfosTiraMigration.Models.AwsModels.PriceListsModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.AwsModels
{
    public class Contact
    {
        public int ID { get; set; }

        public int ClientId { get; set; }

        public int SapContactId { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(50)]
        public string Title { get; set; }

        [StringLength(50)]
        public string Position { get; set; }

        [StringLength(100)]
        public string Address { get; set; }

        [StringLength(20)]
        public string Tel1 { get; set; }

        [StringLength(20)]
        public string Tel2 { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [StringLength(20)]
        public string Fax { get; set; }

        [StringLength(100)]
        public string Mail { get; set; }

        public virtual Client Client { get; set; }

    }
}