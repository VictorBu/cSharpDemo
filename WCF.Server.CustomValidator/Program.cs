using System;
using System.ServiceModel;

namespace WCF.Server.CustomValidator
{
    /// <summary>
    /// 
    /// 使用 BasicHttpBinding 的 TransportCredentialOnly, 不需要提供证书
    /// http://blog.csdn.net/u010724686/article/details/43792399
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(CustomValidatorService)))
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
