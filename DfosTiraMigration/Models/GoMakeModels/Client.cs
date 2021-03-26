using DfosTiraMigration.Models.GoMakeModels.PriceLists;
using DfosTiraMigration.Models.GoMakeModels.PriceListsModels;
using DfosTiraMigration.Models.GoMakeModels.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace DfosTiraMigration.Models.GoMakeModels
{
    public class Client
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Client()
        {
            Addresses = new HashSet<Address>();
            Contacts = new HashSet<Contact>();
            Orders = new HashSet<Order>();
            PriceLists = new HashSet<Quote>();
            SubProducts = new HashSet<SubProduct>();
            IgnoredPricing = new HashSet<IgnoredPricing>();
        }

        public Guid ID { get; set; }

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

        public bool IsActive { get; set; }

        public bool IsInternal { get; set; } = false;

        public Guid ClientTypeId { get; set; }

        public string LastOrderContactName { get; set; }

        public string LastOrderContactPhone { get; set; }

        public string LastOrderContactMail { get; set; }

        public string LastOrderContactAddress { get; set; }

        public Guid? AgentId { get; set; }

        public int SapDocumentsTypeId { get; set; }

        public bool IsOptionalClosingOrder { get; set; }

        public string GeneralNotes { get; set; }

        public string NewItemNotes { get; set; }

        public string CloseOrderNotes { get; set; }

        public Guid PrintHouseId { get; set; }

        public bool IsCreateOrder { get; set; }

        public virtual Employee Agent { get; set; }

        [NotMapped]
        public User User { get; set; }

        [NotMapped]
        public double MatchingPercent { get; set; }

        [ForeignKey("ClientTypeId")]
        public ClientType Client_Type { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubProduct> SubProducts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Address> Addresses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contact> Contacts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Quote> PriceLists { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User> Users { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderItemParametersStatus> OrderItemParametersStatuses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuoteItemParametersStatuses> QuoteItemParametersStatuses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuoteItem> QuoteItems { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderItem> OrderItems { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MainProductSupplier> MainProductSuppliers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubProductSupplier> SubProductSuppliers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IgnoredPricing> IgnoredPricing { get; set; }
        public int? DID { get; set; }
    }
}