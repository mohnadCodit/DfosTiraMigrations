using DfosTiraMigration.Models.GoMakeModels.PriceListsModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.GoMakeModels
{
    public class Address
    {
        public Guid ID { get; set; }
        public int? DID { get; set; }
        public Guid ClientId { get; set; }

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