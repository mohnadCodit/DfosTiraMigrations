using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.GoMakeModels.Products
{
    public class ProductsParameter
    {
        public Guid ID { get; set; }

        public Guid SubProductID { get; set; }

        [Required]
        public string Name { get; set; }

        public string Values { get; set; }

        //public virtual SubProduct SubProduct { get; set; }

        [NotMapped]
        public List<string> splittedValues { get; set; }

        

    }
}