using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Protocol;

namespace SuperSocket.BuiltInProtocol
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1. StringRequestInfo: 命令行协议(默认协议)
             * 命令行协议定义了每个请求必须以回车换行结尾 "\r\n"
             */

            // 1.1. 自定义命令行协议
            var stringRequestInfoServer1 = new StringRequestInfoServer1();
            stringRequestInfoServer1.Setup(2004);
            stringRequestInfoServer1.NewRequestReceived += StringRequestInfoServer_NewRequestReceived;
            stringRequestInfoServer1.Start();            

            // 1.2. 基于接口 IRequestInfoParser 来实现一个 RequestInfoParser 类
            var stringRequestInfoServer2 = new StringRequestInfoServer2();
            stringRequestInfoServer2.Setup(2005);
            stringRequestInfoServer2.NewRequestReceived += StringRequestInfoServer_NewRequestReceived;
            stringRequestInfoServer2.Start();

            /*2. 内置的常用协议实现模版
             */

            // 2.1. TerminatorReceiveFilter (结束符协议): 用结束符来确定一个请求
            var terminatorAppServer = new TerminatorAppServer();
            terminatorAppServer.Setup(2006);
            terminatorAppServer.NewRequestReceived += StringRequestInfoServer_NewRequestReceived;
            terminatorAppServer.Start();

            // 2.2. CountSpliterReceiveFilter (CountSpliterReceiveFilter): 像 "#part1#part2#part3#part4#part5#part6#part7#". 每个请求有7个由 '#' 分隔的部分
            var countSpliterAppServer = new CountSpliterAppServer();
            countSpliterAppServer.Setup(2007);
            countSpliterAppServer.NewRequestReceived += StringRequestInfoServer_NewRequestReceived;
            countSpliterAppServer.Start();

            // 2.3. FixedSizeReceiveFilter (固定请求大小的协议): 所有请求的大小都是相同的
            var fixedSizeAppServer = new FixedSizeAppServer();
            fixedSizeAppServer.Setup(2008);
            fixedSizeAppServer.NewRequestReceived += StringRequestInfoServer_NewRequestReceived;
            fixedSizeAppServer.Start();

            // 2.4. BeginEndMarkReceiveFilter (带起止符的协议): 每个请求都有固定的开始和结束标记
            var beginEndMarkAppServer = new BeginEndMarkAppServer();
            beginEndMarkAppServer.Setup(2009);
            beginEndMarkAppServer.NewRequestReceived += StringRequestInfoServer_NewRequestReceived;
            beginEndMarkAppServer.Start();

            // 2.5. FixedHeaderReceiveFilter (头部格式固定并且包含内容长度的协议): 这种协议将一个请求定义为两大部分, 第一部分定义了包含第二部分长度等等基础信息. 我们通常称第一部分为头部
            var fixedHeaderAppServer = new FixedHeaderAppServer();
            fixedHeaderAppServer.Setup(2010);
            fixedHeaderAppServer.NewRequestReceived += FixedHeaderAppServer_NewRequestReceived;
            fixedHeaderAppServer.Start();


            Console.ReadLine();
            stringRequestInfoServer1.Stop();
            stringRequestInfoServer2.Stop();
            terminatorAppServer.Stop();
            countSpliterAppServer.Stop();
            fixedSizeAppServer.Stop();
            beginEndMarkAppServer.Stop();
            fixedHeaderAppServer.Stop();
            Console.ReadLine();
        }


        static void StringRequestInfoServer_NewRequestReceived(AppSession session, StringRequestInfo requestInfo)
        {
            session.Send(requestInfo.Body);
        }

        static void FixedHeaderAppServer_NewRequestReceived(FixedHeaderSession session, BinaryRequestInfo requestInfo)
        {
            session.Send(requestInfo.Key, requestInfo.Body);
        }
    }
}
