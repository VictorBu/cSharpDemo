using System;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace WCF.Server.ByCode
{
    /// <summary>
    /// 
    /// http://blog.csdn.net/column/details/wcf-example-come.html
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Uri baseAddress = new Uri("http://localhost:8066/service");

            using (ServiceHost host = new ServiceHost(typeof(GithubService), baseAddress))
            {
                WSHttpBinding binding = new WSHttpBinding();
                binding.Security.Mode = SecurityMode.None;//不需要身份验证

                host.AddServiceEndpoint(typeof(IService), binding, "github");

                ServiceMetadataBehavior behavior = new ServiceMetadataBehavior()
                {
                    HttpGetEnabled = true,
                };
                host.Description.Behaviors.Add(behavior);

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
