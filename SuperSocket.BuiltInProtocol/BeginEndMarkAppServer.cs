using System.Text;
using SuperSocket.Common;
using SuperSocket.Facility.Protocol;
using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Protocol;

namespace SuperSocket.BuiltInProtocol
{
    public class BeginEndMarkAppServer : AppServer
    {
        public BeginEndMarkAppServer()
            : base(new DefaultReceiveFilterFactory<BeginEndMarkFilter, StringRequestInfo>())
        {

        }
    }

    public class BeginEndMarkFilter : BeginEndMarkReceiveFilter<StringRequestInfo>
    {
        //开始和结束标记也可以是两个或两个以上的字节
        private readonly static byte[] BeginMark = new byte[] { (byte)'!' };
        private readonly static byte[] EndMark = new byte[] { (byte)'$' };

        public BeginEndMarkFilter()
            : base(BeginMark, EndMark) //传入开始标记和结束标记
        {

        }

        protected override StringRequestInfo ProcessMatchedRequest(byte[] readBuffer, int offset, int length)
        {
            var x = readBuffer.CloneRange(offset, length);
            var body = Encoding.Default.GetString(x);
            return new StringRequestInfo("key", body, null);
        }
    }
}
