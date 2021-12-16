using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification_Service.Model
{
    public class NotifyInstruction
    {
        public int NotificationId { get; set; }
        public string InstructionName { get; set; }
        public DateTime NotificationDate { get; set; }
        public string LastRunDate { get; set; }
        public string NextRunDate { get; set; }
    }
}
