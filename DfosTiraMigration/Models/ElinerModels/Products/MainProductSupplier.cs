﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.ElinerModels.Products
{
    public class MainProductSupplier
    {
        public int ID { get; set; }

        [ForeignKey("MainProduct")]
        public int MainProductId { get; set; }

        [ForeignKey("Supplier")]
        public int ClientId { get; set; }

        public virtual MainProduct MainProduct { get; set; }

        public virtual Client Supplier { get; set; }
    }
}