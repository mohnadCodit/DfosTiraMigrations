using AutoMapper;
using DfosTiraMigration.Models.GoMakeModels.Logs;
using DfosTiraMigration.Models.GoMakeModels.Tracking;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.GoMakeModels.PriceListsModels
{
    public class Order
    {

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            Key = Guid.NewGuid();
            OrdersLogs = new HashSet<OrdersLog>();
            //OrderItems = new HashSet<OrderItem>();
            OrdersTracking = new HashSet<OrdersTracking>();
        }

        public Order(Quote priceList, IMapper mapper)
        {
            Key = Guid.NewGuid();
            //OrderItems = new HashSet<OrderItem>();
        }
       
        public Guid ID { get; set; }
        public int? DID { get; set; }
        public Guid Key { get; set; }

        public Guid UserID { get; set; }

        [ForeignKey("Client")]
        public Guid CustomerID { get; set; }

        [Required]
        public double TotalPrice { get; set; }

        public DateTime CreationDate { get; set; } = DateTime.Now;

        public DateTime? DueDate { get; set; }

        public string Number { get; set; }

        public string PurchaseNumber { get; set; }

        public string Notes { get; set; }

        public virtual Client Client { get; set; }

        public Guid? ContactID { get; set; }

        public Guid? AddressID { get; set; }

        public string ContactName { get; set; }

        public string ContactPhone { get; set; }

        public string ContactMail { get; set; }

        public string ContactAddress { get; set; }

        public string DeliveryNumber { get; set; }

        public string AccountingNumber { get; set; }

        public bool IsClosed { get; set; } = false;

        public Guid? AgentId { get; set; }

       
        public int DeliveryStatusId { get; set; } = 0;

        public int? IdenticalItemsDiscountId { get; set; }

        public Guid PrintHouseId { get; set; }

        public int? SapDocumentTypeId { get; set; }

       
        public virtual Employee Agent { get; set; }

       // [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<OrderItem> OrderItems { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdersTracking> OrdersTracking { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdersLog> OrdersLogs { get; set; }

        public virtual User User { get; set; }

        //[NotMapped]
        //public List<HttpPostedFileBase> files { get; set; }

        [NotMapped]
        public List<string> Files { get; set; }

        // FOR CLIENT UPDATING 
        [NotMapped]
        public int? orderItemUpdated { get; set; }

        [NotMapped]
        public string AgentName { get; set; }

        public virtual Contact Contact { get; set; }

        public virtual Address Address { get; set; }
    }
}