using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.AwsModels.PriceListsModels
{
    public class PrintingItemValue
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PrintingItemValue()
        {
            //OrderItems = new HashSet<OrderItem>();
            //PriceListItems = new HashSet<PriceListItem>();
            PrintingPriceListWorks = new HashSet<PrintingItemWork>();
        }

        public int ID { get; set; }
        public string Rug { get; set; }
        public string Fold { get; set; }
        public string Bord { get; set; }
        public string Other { get; set; }
        public string Kappa { get; set; }
        public string Poster { get; set; }
        public string isMate { get; set; }
        public string Cutting { get; set; }
        public string Sticker { get; set; }
        public string Printing { get; set; }
        public string Laminated { get; set; }
        public string ElseColor { get; set; }
        public string Plexiglass { get; set; }
        public string Shemshonet { get; set; }
        public string Application { get; set; }
        public string Installation { get; set; }
        public string ColourfulSticker { get; set; }
        public string PrintingAndCutting { get; set; }
        public string PlexiglassThickness { get; set; }
        public string ContinuousApplicatioin { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderItem> OrderItems { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuoteItem> QuoteItems { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrintingItemWork> PrintingPriceListWorks { get; set; }
    }
}