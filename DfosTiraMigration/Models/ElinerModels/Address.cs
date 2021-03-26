using DfosTiraMigration.Models.ElinerModels.PriceListsModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.ElinerModels
{
    public class Address
    {
        public int ID { get; set; }

        public int ClientId { get; set; }

        [Column("Address")]
        [Required]
        [StringLength(50)]
        public string Address1 { get; set; }

        [StringLength(50)]
        public string Address2 { get; set; }

        [StringLength(50)]
        public string Address3 { get; set; }

        [StringLength(100)]
        public string Street { get; set; }

        [StringLength(100)]
        public string StreetNumber { get; set; }

        [StringLength(100)]
        public string Block { get; set; }

        [StringLength(100)]
        public string City { get; set; }

        [StringLength(20)]
        public string ZIPCode { get; set; }

        [StringLength(100)]
        public string County { get; set; }

        [StringLength(3)]
        public string State { get; set; }

        [StringLength(3)]
        public string Country { get; set; }

        [StringLength(1)]
        public string AddressType { get; set; }

        public virtual Client Client { get; set; }

    }
}