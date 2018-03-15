using System;
using SuperSocket.SocketBase;
using SuperSocket.SocketEngine;

namespace SuperSocket.ByConfig
{
    /// <summary>
    /// 
    /// http://docs.supersocket.net/v1-6/zh-CN/SuperSocket-Basic-Configuration
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var bootstrap = BootstrapFactory.CreateBootstrap();

            if (!bootstrap.Initialize())
            {
                Console.WriteLine("设置失败!");
                Console.ReadKey();
                return;
            }

            var result = bootstrap.Start();

            if (result == StartResult.Failed)
            {
                Console.WriteLine("启动失败!");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("服务启动成功");

            Console.ReadLine();

            bootstrap.Stop();

            Console.WriteLine("服务关闭!");
            Console.ReadLine();
        }
    }
}
