using System;
using System.Threading;

namespace Quartz.Common
{
    [DisallowConcurrentExecution] //同一时间只有一个 Job2 实例运行
    public class Job2 : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            Console.WriteLine("job 2 :" + DateTime.Now);
            Thread.Sleep(1000*2);
        }
    }
}
