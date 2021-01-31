using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.AwsModels.PriceListsModels
{
    public class NotepadItemValue
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NotepadItemValue()
        {
            //OrderItems = new HashSet<OrderItem>();
            //PriceListItems = new HashSet<PriceListItem>();
        }

        public int ID { get; set; }

        [Required]
        public double Quantity { get; set; }

        public string Size { get; set; }

        public string Side { get; set; }

        public string Color { get; set; }

        public string Copies { get; set; }

        public string Documents { get; set; }

        public string ElseDocuments { get; set; }

        public string NotepadStartNumber { get; set; }

        public string DocumentStartNumber { get; set; }

        public bool DoubleBottom { get; set; }

        public bool Holes { get; set; }

        public bool CopyLast { get; set; }

        public bool GlueSets { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderItem> OrderItems { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuoteItem> QuoteItems { get; set; }
    }
}