using System;

namespace DfosTiraMigration.Models.GoMakeModels
{
    public class AllowedIP
    {
        public Guid ID { get; set; }

        public Guid? UserId { get; set; }

        public string IP { get; set; }

        public string Description { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime UpdateDate { get; set; }

        public virtual User User { get; set; }
    }
}