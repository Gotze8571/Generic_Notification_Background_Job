using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification_Service.Entity
{
    [Table("StandingInstruction_NotificationService_tbl_AuditLog")]
    public class AuditLog
    {
        [Key]
        public int Id { get; set; }
        public string ActivityName { get; set; }
        public DateTime TimeStamp { get; set; }
        public string SIFrequency { get; set; }
        public string SIType { get; set; }
        public string MachineName { get; set; }
        public string ClientId { get; set; }
        public string Status { get; set; }
        public string Instruction_name { get; set; }
        public string customer_id { get; set; }
        public int retrialCount { get; set; }
        public int requestId { get; set; }
        public int SIfrequencyId { get; set; }
        public int SITypeId { get; set; }
    }
}
