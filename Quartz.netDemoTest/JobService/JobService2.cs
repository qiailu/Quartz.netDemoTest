using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quartz.netDemoTest.Job;

namespace Quartz.netDemoTest.JobService
{
    public class JobService2 : JobService<Job2>
    {
        protected override string JobName
        {
            get { return "job2"; }
        }

        public override string GroupName
        {
            get { return "group1"; }
        }

        protected override ITrigger GetTrigger()
        {
            return
                TriggerBuilder.Create().WithIdentity(JobName, GroupName)
                    .WithSimpleSchedule(x => x.WithIntervalInSeconds(AppConfig.Trigger2InSecounds))
                    .Build();
        }
    }
}
