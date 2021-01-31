using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.GoMakeModels.PriceListsModels
{
    public class Analytic
    {

        public Analytic() {
            ID = Guid.NewGuid();
        }

        public Guid ID { get; set; }

        public Guid? PriceListItemID { get; set; }

        public Guid? OrderItemID { get; set; }

        public string Name { get; set; }

        public string Value { get; set; }

        public virtual OrderItem OrderItem { get; set; }

        public virtual QuoteItem PriceListItem { get; set; }
    }
}