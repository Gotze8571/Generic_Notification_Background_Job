using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification_Service.Model
{
    // link to tbl_BackgroundJob_Register
    public class BackgroundJobTracker
    {
        public int Id { get; set; }
        public string AppName { get; set; }
        public string LastTransPick { get; set; }
        public DateTime RecordDate { get; set; }
        public string Status { get; set; }
    }
}
