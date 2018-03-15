using SuperSocket.Facility.Protocol;
using SuperSocket.SocketBase;

namespace SuperSocket.BuiltInProtocol
{
    public class CountSpliterAppServer : AppServer
    {
        public CountSpliterAppServer()
            : base(new CountSpliterReceiveFilterFactory((byte)'#', 8))
        {

        }
    }
}
