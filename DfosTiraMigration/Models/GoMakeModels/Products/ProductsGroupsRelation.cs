using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.GoMakeModels.Products
{
    public class ProductsGroupsRelation
    {
        public Guid ID { get; set; }

        public Guid ProductID { get; set; }

        public Guid GroupID { get; set; }

        public virtual ProductsGroup ProductsGroup { get; set; }

        public virtual SubProduct SubProduct { get; set; }
    }
}