using System;
using System.IO;
using Topshelf;

namespace topshelflog4netquartz
{
    /// <summary>
    /// 
    /// Install-Package Quartz -Version 2.6.1
    /// Install-Package Topshelf -Version 3.3.1
    /// Install-Package Topshelf.Log4Net -Version 3.3.1
    /// 
    /// quartz.config, quartz_jobs.xml, log4net.config 均要设置为 Copy always
    /// 
    /// https://www.cnblogs.com/frozenzhang/archive/2016/04/29/5443778.html
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            log4net.Config.XmlConfigurator.ConfigureAndWatch(new FileInfo("log4net.config"));

            HostFactory.Run(x =>
            {
                x.UseLog4Net();

                x.Service<ServiceRunner>();

                x.RunAsLocalSystem();

                x.SetDescription("Topshelf + Quartz + Log4Net 实现 Windows Service 定时任务");
                x.SetDisplayName("Topshelf Quartz Log4Net");
                x.SetServiceName("TopshelfQuartzLog4Net");

                x.EnablePauseAndContinue();
            });
        }
    }
}
