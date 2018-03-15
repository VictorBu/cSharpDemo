using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Protocol;

namespace SuperSocket.BuiltInProtocol
{
    public class TerminatorAppServer : AppServer
    {
        // 以 "##" 结尾
        public TerminatorAppServer()
            : base(new TerminatorReceiveFilterFactory("##"))
        {

        }
    }
}
