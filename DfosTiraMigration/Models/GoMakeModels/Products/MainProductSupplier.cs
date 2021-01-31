using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.GoMakeModels.Products
{
    public class MainProductSupplier
    {
        public Guid ID { get; set; }

        [ForeignKey("MainProduct")]
        public Guid MainProductId { get; set; }

        [ForeignKey("Supplier")]
        public Guid ClientId { get; set; }

        public virtual MainProduct MainProduct { get; set; }

        public virtual Client Supplier { get; set; }
    }
}