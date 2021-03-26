using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DfosTiraMigration.Models.ElinerModels
{
    public class SMS
    {
        public string OrderNumber { set; get; }
        public string CustomerName { set; get; }
        public string Subject { set; get; }
        public string Content { set; get; }
        public string Phone { set; get; }
        public string Email { set; get; }
        public int TemplateID { set; get; } = 0;
        public HttpPostedFileBase[] Files { set; get; }
        public List<SelectListItem> Clients { get; set; }
        public List<SelectListItem> Templates { get; set; }
    }
}