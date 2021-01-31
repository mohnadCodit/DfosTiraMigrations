namespace DfosTiraMigration.Models.GoMakeModels.PriceListsModels
{
    using DfosTiraMigration.Models.GoMakeModels.PriceLists;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderItemParametersStatuses")]
    public partial class OrderItemParametersStatus
    {
        public OrderItemParametersStatus()
        {
            ID = Guid.NewGuid();
        }
        public Guid ID { get; set; }

        public Guid OrderItemId { get; set; }

        public Guid PriceListParameterId { get; set; }

        public bool IsReady { get; set; }

        public bool IsOO { get; set; }

        [ForeignKey("Supplier")]
        public Guid? SupplierId { get; set; }

        public double? Cost { get; set; }

        public string Name { get; set; }

        public string Value { get; set; }

        [NotMapped]
        public bool IsNew { get; set; }

        public string OOAccountingNumber { get; set; }

        public virtual OrderItem OrderItem { get; set; }

        public virtual PriceListParameter PriceListParameter { get; set; }

        public virtual Client Supplier { get; set; }
    }
}
