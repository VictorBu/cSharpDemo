using System.Linq;
using System.Text;
using SuperSocket.Common;
using SuperSocket.Facility.Protocol;
using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Protocol;

namespace SuperSocket.BuiltInProtocol
{
    public class FixedSizeAppServer : AppServer
    {
        public FixedSizeAppServer()
        : base(new DefaultReceiveFilterFactory<FixedSizeFilter, StringRequestInfo>())
    {

    }
    }

    // 长度为 9
    public class FixedSizeFilter : FixedSizeReceiveFilter<StringRequestInfo>
    {
        public FixedSizeFilter()
            : base(9)
        {

        }

        protected override StringRequestInfo ProcessMatchedRequest(byte[] buffer, int offset, int length, bool toBeCopied)

        {
            //var x = buffer.Skip(offset).Take(length).ToArray();
            var x = buffer.CloneRange(offset, length);
            var body = Encoding.Default.GetString(x);
            return new StringRequestInfo("key", body, null);
        }

    }
}

