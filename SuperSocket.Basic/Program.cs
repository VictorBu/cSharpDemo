using System;
using System.Linq;
using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Protocol;

namespace SuperSocket.Basic
{
    /// <summary>
    /// 
    /// https://github.com/kerryjiang/SuperSocket
    /// 
    /// v1.6
    /// 
    /// Install-Package log4net -Version 2.0.3
    /// 
    /// 引用 SuperSocket 提供的日志配置文件 log4net.config 到项目文件夹的 Config 文件夹然后设置它的 Build Action 为 "Content"
    /// ，设置它的 Copy to Output Directory 为 "Copy if newer"
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var appServer = new AppServer();// 代表了监听客户端连接，承载TCP连接的服务器实例

            if (!appServer.Setup(2000)) //设置监听端口
            {
                Console.WriteLine("设置失败!");
                Console.ReadKey();
                return;
            }

            appServer.NewSessionConnected += appServer_NewSessionConnected;// 注册回话新建事件处理方法

            appServer.NewRequestReceived += appServer_NewRequestReceived;// 注册请求处理方法

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

        /*
         * AppSession: 
         * 代表一个和客户端的逻辑连接，基于连接的操作应该定于在该类之中，
         * 可以用该类的实例发送数据到客户端，接收客户端发送的数据或者关闭连接
         */
        static void appServer_NewSessionConnected(AppSession session)
        {
            session.Send("Hello world!");
        }

        static void appServer_NewRequestReceived(AppSession session, StringRequestInfo requestInfo)
        {
            switch (requestInfo.Key.ToUpper())
            {
                case ("ECHO"):
                    session.Send(requestInfo.Body);
                    break;

                case ("ADD"):
                    session.Send(requestInfo.Parameters.Select(p => Convert.ToInt32(p)).Sum().ToString());
                    break;

                case ("MULT"):

                    var result = 1;

                    foreach (var factor in requestInfo.Parameters.Select(p => Convert.ToInt32(p)))
                    {
                        result *= factor;
                    }

                    session.Send(result.ToString());
                    break;
            }
        }

    }
}
