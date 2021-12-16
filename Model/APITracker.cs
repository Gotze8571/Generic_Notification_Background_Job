using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification_Service.Model
{
    // Link to tbl_Orchestration_BackgroundJob
    public class APITracker
    {
        public int Id { get; set; }
        public string RequestId { get; set; }
        public string Action { get; set; }
        public string Reference { get; set; }
        public string CorrelationId { get; set; }
        public string SourceAccount { get; set; }
        public string DestinationAccount { get; set; }
        public decimal Amount { get; set; }
        public string RequestBody { get; set; }
        public string ResponseBody { get; set; }
        public string RequestTime { get; set; }
        public string ResponseTime { get; set; }
        public string ResponseCode { get; set; }
        public string ResponseMessage { get; set; }
        public string ClientId { get; set; }
        public string Remarks { get; set; }
        public string ApiUrl { get; set; }

    }
}
