using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification_Service.Model
{
    public class APIHeader
    {
        public string ClientId { get; set; }
        public string ClientName { get; set; }
        public string CorrelationId { get; set; }
    }
}
