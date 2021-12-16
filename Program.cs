using Notification_Service.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

namespace Notification_Service
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                HostFactory.Run(hostConfig =>
                {
                    hostConfig.Service<NotifyService>(serviceConfig =>
                    {
                        serviceConfig.ConstructUsing(() => new NotifyService());
                        serviceConfig.WhenStarted(s => s.Start());
                        serviceConfig.WhenStopped(s => s.Stop());
                    });
                    // Setup Account that window use to run.
                    hostConfig.RunAsLocalSystem();
                    hostConfig.SetServiceName("Standing Instruction Service.");
                    hostConfig.SetDisplayName("Standing Instruction Service System.");
                    hostConfig.SetDescription("Service to Pick Standing Instruction.");
                });

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }
    }
}
