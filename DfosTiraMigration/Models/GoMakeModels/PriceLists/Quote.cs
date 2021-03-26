using DfosTiraMigration.Models.GoMakeModels.Logs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DfosTiraMigration.Models.GoMakeModels.PriceListsModels
{
    public class Quote
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Quote()
        {
            Key = Guid.NewGuid();
            QuotesLogs = new HashSet<QuotesLog>();
            PriceListItems = new HashSet<QuoteItem>();
        }
        public int? DID { get; set; }
        public Guid ID { get; set; }

        public Guid Key { get; set; }

        public Guid UserID { get; set; }

        [ForeignKey("Client")]
        public Guid CustomerID { get; set; }

        public DateTime CreationDate { get; set; }

        public double TotalPrice { get; set; }

        public int StatusID { get; set; }

        public string Number { get; set; }

        public string PurchaseNumber { get; set; }

        public string Notes { get; set; }

        public Guid? ContactID { get; set; }

        public Guid? AddressID { get; set; }

        public DateTime? DueDate { get; set; }

        public string ContactName { get; set; }

        public string ContactPhone { get; set; }

        public string ContactMail { get; set; }

        public string ContactAddress { get; set; }

        public virtual Client Client { get; set; }

        public Guid? AgentId { get; set; }

        public int? IdenticalItemsDiscountId { get; set; }

        public Guid PrintHouseId { get; set; }

        public virtual Employee Agent { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuoteItem> PriceListItems { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuotesLog> QuotesLogs { get; set; }

        public virtual User User { get; set; }

        public virtual Contact Contact { get; set; }

        public virtual Address Address { get; set; }

    


    }
}