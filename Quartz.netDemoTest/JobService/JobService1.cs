using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quartz.netDemoTest.Job;

namespace Quartz.netDemoTest.JobService
{
    public class JobService1 : JobService<Job1>
    {
        protected override string JobName
        {
            get { return "job1"; }
        }

        public override string GroupName
        {
            get { return "group1"; }
        }

        protected override ITrigger GetTrigger()
        {
            var trigger = TriggerBuilder.Create()
               .WithIdentity(JobName, GroupName)
               .WithSimpleSchedule(x => x
                   .WithIntervalInSeconds(AppConfig.Trigger1InSecounds)                   
                   .RepeatForever())
               .Build();
            return trigger;
        }
    }
}
