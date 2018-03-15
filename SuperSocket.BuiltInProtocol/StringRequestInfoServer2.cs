using System;
using System.Text;
using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Protocol;

namespace SuperSocket.BuiltInProtocol
{
    public class StringRequestInfoServer2 : AppServer<AppSession>
    {
        public StringRequestInfoServer2()
            : base(new CommandLineReceiveFilterFactory(Encoding.Default, new StringRequestInfoRequestInfoParser()))
        {

        }
    }

    // 命令格式："LOGIN:kerry,12345" + NewLine
    public class StringRequestInfoRequestInfoParser : IRequestInfoParser<StringRequestInfo>
    {
        private readonly string m_Spliter = ":";
        private readonly string[] m_ParameterSpliters = new string[] { "," };

        public StringRequestInfo ParseRequestInfo(string source)
        {
            int pos = source.IndexOf(m_Spliter);

            string name = string.Empty;
            string param = string.Empty;

            if (pos > 0)
            {
                name = source.Substring(0, pos);
                param = source.Substring(pos + m_Spliter.Length);
            }
            else
            {
                name = source;
            }

            return new StringRequestInfo(name, param,
                param.Split(m_ParameterSpliters, StringSplitOptions.RemoveEmptyEntries));
        }
    }
}
