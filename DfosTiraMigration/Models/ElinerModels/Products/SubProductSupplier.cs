using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.ElinerModels.Products
{
    public class SubProductSupplier
    {
        public int ID { get; set; }

        [ForeignKey("SubProduct")]
        public int SubProductId { get; set; }

        [ForeignKey("Supplier")]
        public int ClientId { get; set; }

        public virtual SubProduct SubProduct { get; set; }

        public virtual Client Supplier { get; set; }
    }
}