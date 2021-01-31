using DfosTiraMigration.Models.GoMakeModels.PriceListsModels;
using System;

namespace DfosTiraMigration.Models.GoMakeModels
{
    public class OrderFile
    {
        public Guid ID { get; set; }

        public Guid OrderId { get; set; }

        public string FileName { get; set; }

        public string FilePath { get; set; }

        public virtual Order Order { get; set; }
    }
}