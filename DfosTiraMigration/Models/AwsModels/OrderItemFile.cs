using DfosTiraMigration.Models.AwsModels.PriceListsModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DfosTiraMigration.Models.AwsModels
{
    public class OrderItemFile
    {
        public int ID { get; set; }

        public int OrderItemId { get; set; }

        public string FileName { get; set; }

        public string FilePath { get; set; }

        public string FileLocalPath { get; set; }

        public int FileTypeId { get; set; }

        public DateTime Created { get; set; } = DateTime.Now;

        public virtual OrderItem OrderItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderItemFileImage> OrderItemFileImages { get; set; }

        [NotMapped]
        public int MissionID { get; set; }
    }
}