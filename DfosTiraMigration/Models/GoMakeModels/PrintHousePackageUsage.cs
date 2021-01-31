using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.GoMakeModels
{
    public class PrintHousePackageUsage
    {
        public Guid Id { get; set; }

        public int UsersNum { get; set; } //מספר משתמשים
        public int ORMissionsNum { get; set; }  //מספר פקודות עבודה    
        public int QuotesNum { get; set; } //מספר הצעות מחיר
        public int SMSNum { get; set; } // מספר הודעות SMS
        public int StorageCapacity { get; set; } //נפח אחסון
        public bool IsActive { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}