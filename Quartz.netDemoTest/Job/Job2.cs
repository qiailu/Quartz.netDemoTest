using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Ymatou.CommonService;

namespace Quartz.netDemoTest.Job
{
    public class Job2 : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            var msg = string.Format("*****【{0}】处理Job2的逻辑*****{1}", Thread.CurrentThread.ManagedThreadId, DateTime.Now.ToString("r"));
            Console.WriteLine(msg);
            ApplicationLog.Info(msg);
        }
    }
}
