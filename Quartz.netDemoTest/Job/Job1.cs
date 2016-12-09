using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Ymatou.CommonService;

namespace Quartz.netDemoTest.Job
{
    public class Job1 : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            string msg = string.Format("-----【{0}】处理Job1的逻辑------{1}", Thread.CurrentThread.ManagedThreadId, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss fff"));
            Console.WriteLine(msg);
            ApplicationLog.Info(msg);
        }
    }
}
