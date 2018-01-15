using System;
using System.Timers;

namespace Topshelf.Demo
{
    public class ServiceRunner : ServiceControl
    {
        private readonly Timer timer;

        public ServiceRunner()
        {
            timer = new Timer(1000) { AutoReset = true };

            timer.Elapsed += new ElapsedEventHandler(Execute);
        }
        public bool Start(HostControl hostControl)
        {
            timer.Start();

            return true;
        }

        public bool Stop(HostControl hostControl)
        {
            timer.Stop();

            return true;
        }

        private static void Execute(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine(DateTime.Now);
        }
    }
}
