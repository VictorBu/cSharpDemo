using System;
using SuperSocket.SocketBase;

namespace SuperSocket.Command
{
    /// <summary>
    /// 
    /// 在多个独立的类中处理各自不同的请求的命令
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var appServer = new AppServer();

            if (!appServer.Setup(2001))
            {
                Console.WriteLine("设置失败!");
                Console.ReadKey();
                return;
            }

            //appServer.NewRequestReceived += appServer_NewRequestReceived;// 注册请求处理方法

            Console.WriteLine();

            if (!appServer.Start())
            {
                Console.WriteLine("启动失败!");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("服务启动成功");

            Console.ReadLine();

            appServer.Stop();

            Console.WriteLine("服务关闭!");
            Console.ReadLine();
        }
    }
}
