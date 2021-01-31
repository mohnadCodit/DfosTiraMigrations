using DfosTiraMigration.Models.GoMakeModels.PriceListsModels;
using DfosTiraMigration.Models.GoMakeModels.Products;
using System;
using System.Collections.Generic;

namespace DfosTiraMigration.Models.GoMakeModels.PriceLists
{
    public class PriceListParameter
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PriceListParameter()
        {
            SubProductParameters = new HashSet<SubProductParameter>();
            PriceListParametersBoards = new HashSet<PriceListParametersBoard>();
            OrderItemParametersStatuses = new HashSet<OrderItemParametersStatus>();
            QuoteItemParametersStatuses = new HashSet<QuoteItemParametersStatuses>();
        }

        public Guid ID { get; set; }

        public Guid PriceListId { get; set; }

        public string Name { get; set; }

        public string Values { get; set; }

        public string DefaultValue { get; set; }

        public string HtmlInputId { get; set; }

        public bool IsRequired { get; set; } = false;

        public int? SheetRowIdentity { get; set; }

        public int SheetRowOrder { get; set; }

        public bool IsVisible { get; set; } = true;

        public string StationTitle { get; set; }

        public virtual PriceList PriceList { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PriceListParametersBoard> PriceListParametersBoards { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderItemParametersStatus> OrderItemParametersStatuses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuoteItemParametersStatuses> QuoteItemParametersStatuses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubProductParameter> SubProductParameters { get; set; }
    }
}