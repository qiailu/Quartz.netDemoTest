using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Logging.Configuration;
using Quartz.Impl;

namespace Quartz.netDemoTest
{
    public class ScheduleBase
    {
        private static IScheduler _scheduler;

        public static IScheduler Scheduler
        {
            get
            {
                if (_scheduler != null)
                {
                    return _scheduler;
                }

                System.Collections.Specialized.NameValueCollection properties = new System.Collections.Specialized.NameValueCollection();
                properties["quartz.scheduler.instanceName"] = "电商后台作业监控系统";

                // 设置线程池
                properties["quartz.threadPool.type"] = "Quartz.Simpl.SimpleThreadPool, Quartz";
                properties["quartz.threadPool.threadCount"] = "6";
                properties["quartz.threadPool.threadPriority"] = "Normal";

                // 远程输出配置
                properties["quartz.scheduler.exporter.type"] = "Quartz.Simpl.RemotingSchedulerExporter, Quartz";
                properties["quartz.scheduler.exporter.port"] = "8008";
                properties["quartz.scheduler.exporter.bindName"] = "QuartzScheduler";
                properties["quartz.scheduler.exporter.channelType"] = "tcp";

                var schedulerFactory = new StdSchedulerFactory(properties);
                _scheduler = schedulerFactory.GetScheduler();

                return _scheduler;
            }
        }

        public static void AddScheduler<T>(JobService<T> service) where T : IJob
        {
            service.AddJobToSchedule(Scheduler);
        }
    }
}
