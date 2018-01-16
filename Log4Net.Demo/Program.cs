using System;
using System.IO;
using log4net;

namespace Log4Net.Demo
{
    /// <summary>
    /// 
    /// Install-Package log4net -Version 1.2.10
    /// 
    /// log4net.config 要设置为 Copy always
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            log4net.Config.XmlConfigurator.ConfigureAndWatch(new FileInfo("log4net.config"));

            ILog logger = LogManager.GetLogger("RollingLogFileAppender");

            logger.Info("log information");

            logger.Warn("log warning");

            logger.Error("log error", new Exception("exception information"));

            Console.ReadKey();
        }
    }
}
