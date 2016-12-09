using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using log4net.Config;
using Quartz.netDemoTest.Job;
using Quartz.netDemoTest.JobService;
using Ymatou.CommonService;

namespace Quartz.netDemoTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //log4net配置
            XmlConfigurator.Configure();
            ApplicationLog.Info("程序开启！");
            Console.WriteLine("********************程序开始执行******************");
            ScheduleBase.Scheduler.Start();

            ScheduleBase.AddScheduler(new JobService1());
            ScheduleBase.AddScheduler(new JobService2());

            Console.ReadKey();
        }
    }
}
