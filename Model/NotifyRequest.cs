using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification_Service.Model
{
    public class NotifyRequest
    {
        public string MailFrom { get; set; }
        public string MailTo { get; set; }
        public string CcMail { get; set; }
        public string BccMail { get; set; }
        public string SubjectMail { get; set; }
        public string MailBody { get; set; }
        public string AttachmentMail { get; set; }
    }
}
