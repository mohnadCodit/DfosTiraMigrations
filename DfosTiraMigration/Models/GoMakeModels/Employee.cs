namespace DfosTiraMigration.Models.GoMakeModels
{
    using DfosTiraMigration.Models.GoMakeModels.PriceListsModels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            Clients = new HashSet<Client>();
            Users = new HashSet<User>();
            Orders = new HashSet<Order>();
            Quotes = new HashSet<Quote>();
            Reports = new HashSet<Report>();
        }

        public Guid ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Firstname { get; set; }

        [Required]
        [StringLength(50)]
        public string Lastname { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        public bool IsActive { get; set; }

        public bool IsAgent { get; set; }

        public string MailService { get; set; }

        public string MailServicePassword { get; set; }

        public DateTime CreationDate { get; set; }
       // public Guid? MailProviderId { get; set; }

        public Guid PrintHouseId { get; set; }
       

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Quote> Quotes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Client> Clients { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User> Users { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Report> Reports { get; set; }

        [NotMapped]
        public virtual IEnumerable<Order> agentOrders { get; set; }

        public int? DID { get; set; }
    }
}
