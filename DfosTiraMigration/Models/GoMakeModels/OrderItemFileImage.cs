using System;

namespace DfosTiraMigration.Models.GoMakeModels
{
    public class OrderItemFileImage
    {
        public Guid ID { get; set; }

        public Guid OrderItemFileId { get; set; }

        public string ImageName { get; set; }

        public string ImagePath { get; set; }

        public string FileContent { get; set; }

        public DateTime Created { get; set; } = DateTime.Now;

        public virtual OrderItemFile OrderItemFile { get; set; }
    }
}