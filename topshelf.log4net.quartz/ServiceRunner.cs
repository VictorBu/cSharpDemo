﻿using Quartz;
using Quartz.Impl;
using Topshelf;

namespace topshelflog4netquartz
{
    public class ServiceRunner : ServiceControl, ServiceSuspend
    {
        private readonly IScheduler scheduler;

        public ServiceRunner()
        {
            scheduler = StdSchedulerFactory.GetDefaultScheduler();
        }

        public bool Start(HostControl hostControl)
        {
            scheduler.Start();
            return true;
        }

        public bool Stop(HostControl hostControl)
        {
            scheduler.Shutdown();
            return true;
        }

        public bool Continue(HostControl hostControl)
        {
            scheduler.ResumeAll();
            return true;
        }

        public bool Pause(HostControl hostControl)
        {
            scheduler.PauseAll();
            return true;
        }
    }
}
