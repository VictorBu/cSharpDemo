using System.Text;
using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Protocol;

namespace SuperSocket.BuiltInProtocol
{
    public class StringRequestInfoServer1:AppServer<AppSession>
    {
        // 命令格式："LOGIN:kerry,12345" + NewLine
        public StringRequestInfoServer1()
            :base(new CommandLineReceiveFilterFactory(Encoding.Default, new BasicRequestInfoParser(":", ",")))
        {
            
        }
    }
}
