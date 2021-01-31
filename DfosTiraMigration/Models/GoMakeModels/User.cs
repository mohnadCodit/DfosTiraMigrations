namespace DfosTiraMigration.Models.GoMakeModels
{
    using DfosTiraMigration.Models.GoMakeModels.BoardModels;
    using DfosTiraMigration.Models.GoMakeModels.Logs;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        public User()
        {
            //BoardUserPermissions = new HashSet<BoardUserPermission>();
            //BoardUsers = new HashSet<BoardUser>();
            //PriceLists = new HashSet<PriceList>();
            AllowedIPs = new HashSet<AllowedIP>();
        }

        public Guid ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        public Guid? EmployeeId { get; set; }

        public Guid? CustomerId { get; set; }

        public Guid ImageID { get; set; }

        public Guid RoleID { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreationDate { get; set; }

        public Guid PrintHouseId { get; set; }

        public virtual Client Customer { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Image Image { get; set; }

        public virtual Role Role { get; set; }

        [NotMapped]
        public string UserIPAddress { get; set; }

        [NotMapped]
        public bool ShowInternal { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BoardUserPermission> BoardUserPermissions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BoardUsers> BoardUsers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GeneralUsersLog> GeneralUsersLogs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BoardMissionsLog> BoardMissionsLogs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdersLog> OrdersLogs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuotesLog> QuotesLogs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AllowedIP> AllowedIPs { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<PriceList> PriceLists { get; set; }
    }
}
