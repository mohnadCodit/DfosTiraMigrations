using System.Collections.Generic;
using System.Web;

namespace TiraPress_ClientsSyncAPI.Models.DTO
{
    public class FileUploadDTO
    {

        public int orderItemId { get; set; }

        public string distPath { get; set; }

        // Helpers Files
        public List<HttpPostedFileBase> helpersFiles { get; set; }
        public string[] helpersFilesNames { get; set; }
        public string[] helpersFilesLocations { get; set; }

        // Printing Files
        public string[] printingFilesNames { get; set; }
        public string[] printingFilesLocations { get; set; }
        public List<HttpPostedFileBase> printingFiles { get; set; }
    }
}