using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.GoMakeModels.Products
{
    public class SubProductSupplier
    {
        public Guid ID { get; set; }

        [ForeignKey("SubProduct")]
        public Guid SubProductId { get; set; }

        [ForeignKey("Supplier")]
        public Guid ClientId { get; set; }

        public virtual SubProduct SubProduct { get; set; }

        public virtual Client Supplier { get; set; }
    }
}