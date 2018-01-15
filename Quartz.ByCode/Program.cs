using Quartz.Common;
using Quartz.Impl;

namespace Quartz.ByCode
{
    /// <summary>
    /// 
    /// Install-Package Quartz -Version 2.6.1
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            IScheduler scheduler = StdSchedulerFactory.GetDefaultScheduler();//调度器

            string jobName = "job1", groupName = "defaultGroup";
            IJobDetail job = JobBuilder.Create<Job1>().WithIdentity(jobName, groupName).Build();

            ITrigger trigger = TriggerBuilder.Create()
                .WithIdentity(jobName, groupName)
                .WithCronSchedule("0/1 * * * * ?")//1秒执行1次
                .Build();//触发器

            scheduler.ScheduleJob(job, trigger);

            scheduler.Start();
        }
    }
}
