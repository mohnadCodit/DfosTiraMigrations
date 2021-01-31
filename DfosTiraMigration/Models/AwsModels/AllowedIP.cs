using System;

namespace DfosTiraMigration.Models.AwsModels
{
    public class AllowedIP
    {
        public int ID { get; set; }

        public int? UserId { get; set; }

        public string IP { get; set; }

        public string Description { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime UpdateDate { get; set; }

        public virtual User User { get; set; }
    }
}