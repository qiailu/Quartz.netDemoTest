using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quartz.netDemoTest
{
    public abstract class JobService<T> where T : IJob
    {
        protected abstract string JobName { get; }

        public abstract string GroupName { get; }

        private IJobDetail GetJobDetial()
        {
            var job = JobBuilder.Create<T>()
                      .WithIdentity(JobName, GroupName)
                      .Build();
            return job;
        }

        protected abstract ITrigger GetTrigger();

        public void AddJobToSchedule(IScheduler scheduler)
        {
            scheduler.ScheduleJob(GetJobDetial(), GetTrigger());
        }

    }
}
