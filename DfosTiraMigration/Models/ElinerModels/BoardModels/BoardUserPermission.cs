using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using DfosTiraMigration.Models.ElinerModels;

namespace DfosTiraMigration.Models.ElinerModels.BoardModels
{
    public class BoardUserPermission
    {
        public int ID { get; set; }

        public int UserId { get; set; }

        public int BoardId { get; set; }

        public int BoardPermissionId { get; set; }

        public virtual BoardPermission BoardPermission { get; set; }

        public virtual Boards Board { get; set; }

        public virtual User User { get; set; }

        [NotMapped]
        public bool IsSelected { get; set; }
    }
}