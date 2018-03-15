using System;
using System.Text;
using SuperSocket.Common;
using SuperSocket.Facility.Protocol;
using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Protocol;

namespace SuperSocket.BuiltInProtocol
{
    public class FixedHeaderAppServer: AppServer<FixedHeaderSession, BinaryRequestInfo>
    {
        public FixedHeaderAppServer()
            : base(new DefaultReceiveFilterFactory<FixedHeaderFilter, BinaryRequestInfo>())
        {

        }
    }

    public class FixedHeaderSession : AppSession<FixedHeaderSession, BinaryRequestInfo>
    {
        protected override void HandleException(Exception e)
        {

        }
    }

    // 头部包含 6 个字节, 前 4 个字节用于存储请求的名字, 后两个字节用于代表请求体的长度
    class FixedHeaderFilter : FixedHeaderReceiveFilter<BinaryRequestInfo>
    {
        public FixedHeaderFilter()
            : base(6)
        {

        }

        protected override int GetBodyLengthFromHeader(byte[] header, int offset, int length)
        {
            return (int)header[offset + 4] * 256 + (int)header[offset + 5];
        }

        protected override BinaryRequestInfo ResolveRequestInfo(ArraySegment<byte> header, byte[] bodyBuffer, int offset, int length)
        {
            return new BinaryRequestInfo(Encoding.Default.GetString(header.Array, header.Offset, 4), bodyBuffer.CloneRange(offset, length));
        }
    }
}
