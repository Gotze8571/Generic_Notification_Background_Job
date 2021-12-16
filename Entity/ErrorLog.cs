using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification_Service.Entity
{
    [Table("StandingInstruction_NotificationService_tbl_ErrorLog")]
    public class ErrorLog
    {
        [Key]
        public int Id { get; set; }
        public string Message { get; set; }
        public string Level { get; set; }
        public DateTime TimeStamp { get; set; }
        public string Exception { get; set; }
        public string SIType { get; set; }
        public string SIFrequency { get; set; }
    }
}
