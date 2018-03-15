using System;
using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Protocol;

namespace SuperSocket.ByConfig
{
    public class TelnetSession : AppSession<TelnetSession>
    {
        protected override void OnSessionStarted()
        {
            Send("Welcome to SuperSocket Telnet Server");
        }

        protected override void HandleUnknownRequest(StringRequestInfo requestInfo)
        {
            Send("Unknow request");
        }

        protected override void HandleException(Exception e)
        {
            Send("Application error: {0}", e.Message);
        }

        //protected override void OnSessionClosed(CloseReason reason)
        //{
        //    base.OnSessionClosed(reason);
        //}
    }
}
