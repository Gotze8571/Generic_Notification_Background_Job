using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification_Service.Model
{
    public class NotificationInstruction
    {
        public int StandingInstructionId { get; set; }
        public string StandingInstructionType { get; set; }
        public string StandingInstructionFrequency { get; set; }
        public string StandingInstructionStatus { get; set; }
        public DateTime LastRunDate { get; set; }
        public DateTime PresentRunDate { get; set; }
        public bool LastMailSent { get; set; }
    }
}
