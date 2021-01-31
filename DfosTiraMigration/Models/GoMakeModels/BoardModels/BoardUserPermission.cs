using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using DfosTiraMigration.Models.GoMakeModels;

namespace DfosTiraMigration.Models.GoMakeModels.BoardModels
{
    public class BoardUserPermission
    {
        public Guid ID { get; set; }

        public Guid UserId { get; set; }

        public Guid BoardId { get; set; }

        public int BoardPermissionId { get; set; }

        public virtual Boards Board { get; set; }

        public virtual User User { get; set; }

        [NotMapped]
        public bool IsSelected { get; set; }
    }
}