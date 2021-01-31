using System;

namespace DfosTiraMigration.Models.AwsModels
{
    public class OrderItemFileImage
    {
        public int ID { get; set; }

        public int OrderItemFileId { get; set; }

        public string ImageName { get; set; }

        public string ImagePath { get; set; }

        public string FileContent { get; set; }

        public DateTime Created { get; set; } = DateTime.Now;

        public virtual OrderItemFile OrderItemFile { get; set; }
    }
}