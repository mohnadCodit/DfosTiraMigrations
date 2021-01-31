using System;

namespace DfosTiraMigration.Models.GoMakeModels
{
    public class BoardUsers
    {
        public Guid ID { get; set; }
        public Guid UserID { get; set; }
        public Guid BoardID { get; set; }
        public Boards Board { get; set; }
        public virtual User User { get; set; }
    }
}