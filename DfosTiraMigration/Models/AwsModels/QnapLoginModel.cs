using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.AwsModels
{
    public class QnapLoginModel
    {

        public int status { get; set; }
        public string sid { get; set; }
        public string servername { get; set; }
        public string username { get; set; }
        public int admingroup { get; set; }
        public int supportACL { get; set; }
        public int enableACL { get; set; }
        public int dateFormat { get; set; }
        public int timeFormat { get; set; }
        public int genericModel { get; set; }
        public int _2sv_type { get; set; }
        public int need_2sv { get; set; }
        public int send_mail_status { get; set; }
        public string authSid { get; set; }
        public int lost_phone { get; set; }
        public int emergency_try_count { get; set; }
        public int emergency_try_limit { get; set; }
        public int security_question_no { get; set; }
        public string security_question_text { get; set; }
        public string cuid { get; set; }
        public int authPassed { get; set; }
        public string version { get; set; }
        public string build { get; set; }

    }
}