using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.ElinerModels.PriceListsModels
{
    public class Analytic
    {

        public Analytic() { }

        public int ID { get; set; }

        public int? PriceListItemID { get; set; }

        public int? OrderItemID { get; set; }

        public string Name { get; set; }

        public string Value { get; set; }

        public virtual OrderItem OrderItem { get; set; }

        public virtual QuoteItem PriceListItem { get; set; }
    }
}