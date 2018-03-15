using System;

namespace SuperSocket.SelfDefinedAppSession
{
    class Program
    {
        static void Main(string[] args)
        {
            var telnetServer = new TelnetServer();

            if (!telnetServer.Setup(2002))
            {
                Console.WriteLine("设置失败!");
                Console.ReadKey();
                return;
            }

            Console.WriteLine();

            if (!telnetServer.Start())
            {
                Console.WriteLine("启动失败!");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("服务启动成功");

            Console.ReadLine();

            telnetServer.Stop();

            Console.WriteLine("服务关闭!");
            Console.ReadLine();
        }
    }
}
