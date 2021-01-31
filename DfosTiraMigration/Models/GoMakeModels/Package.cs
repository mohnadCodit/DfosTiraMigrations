using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.GoMakeModels
{
    public class Package
    {
        public Guid Id { get; set; }
        public string Name { get; set; } //שם חבילה להצגה
        public double Price { get; set; } // מחיר
        public int UsersNum { get; set; } //מספר משתמשים
        public int ORMissionsNum { get; set; }  //מספר פקודות עבודה    
        public int QuotesNum { get; set; } //מספר הצעות מחיר
        public int SMSNum { get; set; } // מספר הודעות SMS
        public int StorageCapacity { get; set; } //נפח אחסון
        public int LogsExpirationInMonths { get; set; } //תקופת רישום לוגים
    }
}