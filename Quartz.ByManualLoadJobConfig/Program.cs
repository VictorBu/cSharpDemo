using Quartz.Impl;

namespace Quartz.ByManualLoadJobConfig
{
    /// <summary>
    /// 
    /// Install-Package Quartz -Version 2.6.1
    /// 
    /// quartz.config 要设置为 Copy always
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            ISchedulerFactory factory = new StdSchedulerFactory(new System.Collections.Specialized.NameValueCollection()
                {
                    {"quartz.plugin.xml.fileNames","~/quartz_jobs.xml" },
                    {"quartz.plugin.xml.type","Quartz.Plugin.Xml.XMLSchedulingDataProcessorPlugin,Quartz"},
                });

            IScheduler scheduler = factory.GetScheduler();

            scheduler.Start();
        }
    }
}
