using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.ElinerModels.DataTable
{
    public class EmployeesGridSource
    {
        public int ID { get; set; }

        public int UserId { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string RoleName { get; set; }

        public DateTime CreationDate { get; set; }
    }
}