using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification_Service.Model
{
    // Link to StandingInstructionAPI_tbl_instruction
    public class FulFillDetails
    {
        public int Id { get; set; }
        public string instruction_name { get; set; }
        public DateTime request_date { get; set; }
        public string customer_id { get; set; }
        public string source_account { get; set; }
        public string destination_account { get; set; }
        public string destination_bank_code { get; set; }
        public string destination_bank_name { get; set; }
        public string narration { get; set; }
        public decimal amount { get; set; }
        public string start_date { get; set; }
        public string status { get; set; }
        public string next_run_date { get; set; }
        public string last_run_status { get; set; }
        public DateTime end_date { get; set; }
        public string last_run_status_details { get; set; }
        public string destination_accountName { get; set; }
        public string last_next_day_mail_sent { get; set; }
        public string mail_sent_day_before { get; set; }
        public DateTime last_run_date { get; set; }
        public string channel { get; set; }
        public string mailSend1 { get; set; }
        public string MailSendDate2 { get; set; }
        public int retrialCount { get; set; }
        public string requestId { get; set; }
        public int SIFrequencyId { get; set; }
        public int SITypeId { get; set; }

    }
}
