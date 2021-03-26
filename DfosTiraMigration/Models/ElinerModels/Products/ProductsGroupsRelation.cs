using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.ElinerModels.Products
{
    public class ProductsGroupsRelation
    {
        public int ID { get; set; }

        public int ProductID { get; set; }

        public int GroupID { get; set; }

        public virtual ProductsGroup ProductsGroup { get; set; }

        public virtual SubProduct SubProduct { get; set; }
    }
}