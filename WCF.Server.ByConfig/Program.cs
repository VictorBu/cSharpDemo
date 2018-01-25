using System;
using System.ServiceModel;

namespace WCF.Server.ByConfig
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(CSharpDemoService)))
            {
                host.Opened += (sender, e) => Console.WriteLine("服务启动成功...");

                try
                {
                    host.Open();

                    Console.ReadLine();

                    host.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("服务启动失败：" + ex);
                }
            }
        }
    }
}
