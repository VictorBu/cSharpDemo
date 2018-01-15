using Quartz.Impl;

namespace Quartz.AutoLoadJob
{
    /// <summary>
    /// 
    /// Install-Package Quartz -Version 2.6.1
    /// 
    /// quartz.config, quartz_jobs.xml 均要设置为 Copy always
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            IScheduler scheduler = StdSchedulerFactory.GetDefaultScheduler();
            scheduler.Start();
        }
    }
}
