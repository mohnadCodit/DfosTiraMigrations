namespace DfosTiraMigration.Models.AwsModels
{
    using DfosTiraMigration.Models.AwsModels.PriceListsModels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BusinessPartner
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BusinessPartner()
        {
            BusinessPartnerContacts = new HashSet<BusinessPartnerContact>();
            OrderItemParametersStatuses = new HashSet<OrderItemParametersStatus>();
            QuoteItemParametersStatuses = new HashSet<QuoteItemParametersStatuses>();
            OrderItems = new HashSet<OrderItem>();
            QuoteItems = new HashSet<QuoteItem>();
        }

        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Nickname { get; set; }

        public string Mail { get; set; }

        [Required]
        public string Phone { get; set; }

        public bool IsActive { get; set; } = false;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BusinessPartnerContact> BusinessPartnerContacts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuoteItemParametersStatuses> QuoteItemParametersStatuses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderItemParametersStatus> OrderItemParametersStatuses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderItem> OrderItems { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuoteItem> QuoteItems { get; set; }
    }
}
