using NLog;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Notification_Service.Service
{
    public class NotifyService
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        private static System.Timers.Timer timer;
       
        public NotifyService()
        {
            try
            {
                Logger.Info("Notification Service Starting...");
                timer = new System.Timers.Timer(86400)
                {
                    AutoReset = true
                };
                timer.Elapsed += TimerElapsed;
                timer.Enabled = true;
                Console.WriteLine("The window service has sent the message!!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Logger.Error("Service caught an Exception!!");
            }
        }

        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            Logger.Info("Notification Service Starting...");
            // buisness logic goes here
            try
            {
                  var recepientMail = ConfigurationManager.AppSettings["EmailRecepient"].ToString();

                Logger.Info("The recipient mail: " + recepientMail);
                Console.WriteLine("The receipt mail is:" + recepientMail);

                Console.WriteLine("The mail is sent: 1 with timeElapsed");
            
                Console.WriteLine("The Elapsed event was raised at {0:HH:mm:ss:fff}", e.SignalTime);
                timer.Stop();
                timer.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Logger.Info("Started successfully.");
        }
        public void Start()
        {
            // Call the NotificationAPI
        }
        public void Stop() { }

        // Weekly SI, everday from 2 days to the next run date.
        // Monthly SI, everyday from 3 days to the next run date.
        // Quarterly SI, everyday from 7 days to the next run date.
        // Yearly SI, every 7 days from 1 month to the next run date.
        public void NotifyPeroid()
        {
            try
            {
                int DateCounter = 0;
                int ExactDateToRunDate = 0;
                int SITypeId = 0;

                // Weekly 
                if (SITypeId == 2)
                {
                    CallNotificationAPI();
                    //foreach(DateCounter >= 0 <= 2)
                    // {
                    //     for (int DateCounter > 0; DateCounter++; DateCounter)
                    //     {

                    //     }
                    // }
                }
                // Mothly
                else if (SITypeId == 3)
                {
                    CallNotificationAPI();
                }
                // Quarterly
                else if (SITypeId == 4)
                {
                    CallNotificationAPI();
                }
                // Yearly
                else if (SITypeId == 5)
                {
                    CallNotificationAPI();
                }
                else
                {
                    CallNoSITypeId();
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
            }
        }
        // No case of No SITypeId
        private void CallNoSITypeId()
        {
            throw new NotImplementedException();
        }
        // Calling NotificationAPI
        private void CallNotificationAPI()
        {
            throw new NotImplementedException();
        }
    }
    
}
