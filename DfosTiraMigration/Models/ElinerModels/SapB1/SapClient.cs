using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DfosTiraMigration.Models.ElinerModels.SapB1
{
    public class SapClient
    {
        public SapClient()
        {
            Contacts = new HashSet<Contact>();
            Addresses = new HashSet<Address>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(15)]
        public string Code { get; set; }

        [StringLength(1)]
        public string ClientType { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(100)]
        public string FName { get; set; }

        [StringLength(32)]
        public string BuisnessNumber { get; set; }

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

        [StringLength(100)]
        public string InternetSite { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public string AddressType { get; set; }

        public bool IsActive { get; set; }

        public virtual ICollection<Contact> Contacts { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }

        public string AgentName { get; set; }

        public int? RelatedGroupId { get; set; }

    }
}