using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.GoMakeModels.DataTable
{
    public class ClientsGridSource
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Client_Type { get; set; }
        public string Code { get; set; }
        public string Mail { get; set; }
        public string Fax { get; set; }
        public string Phone { get; set; }
        public string Tel1 { get; set; }
        public string Tel2 { get; set; }
        public bool IsActive { get; set; }
        public bool IsInternal { get; set; }
    }
}