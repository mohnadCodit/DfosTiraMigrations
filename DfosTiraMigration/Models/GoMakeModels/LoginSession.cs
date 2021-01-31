using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.GoMakeModels
{
    public class LoginSession
    {
        public Guid ID { get; set; }
        public Guid UserId { get; set; }
        public Guid PrintHouseId { get; set; }
        public DateTime Created { get; set; }
        public Guid HubConnectionId { get; set; }
    }
}