using System;
using System.Linq;
using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Command;
using SuperSocket.SocketBase.Protocol;

namespace SuperSocket.Command
{
    public class MULT : CommandBase<AppSession, StringRequestInfo>
    {
        public override void ExecuteCommand(AppSession session, StringRequestInfo requestInfo)
        {
            var result = 1;

            foreach (var factor in requestInfo.Parameters.Select(p => Convert.ToInt32(p)))
            {
                result *= factor;
            }

            session.Send(result.ToString());
        }
    }
}
